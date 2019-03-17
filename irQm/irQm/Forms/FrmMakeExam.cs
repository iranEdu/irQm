using FarsiLibrary.Utils;
using irQm.BaseCodes;
using irQm.UserControls.qPresentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.Forms
{
    public partial class FrmMakeExam : Form
    {
        private List<IQuestion> Questions;
        private int lastIndex;
        private float totalMark;
        public FrmMakeExam(List<IQuestion> questions)
        {

            InitializeComponent();
            this.ShowInTaskbar = false;
            Questions = questions;
            for(int i=0;i<60;i++)
            {
                comboStartMinute.Items.Add(i);
                comboMinute.Items.Add(i);

            }
            for (int i = 0; i < 24; i++)
            {
                comboStartHour.Items.Add(i);
                comboHour.Items.Add(i);
            }
            comboStartMinute.Text = "0";
            comboStartHour.Text = "10";
            comboHour.Text = "1";
            comboMinute.Text = "0";
            
        }

        private void Qitem_MarkChanged(UCExamQuestionListItem item, IQuestion question)
        {
            totalMark= Questions.Sum(q => q.Score) ;
            lblTotalMark.Text = totalMark.ToString();
        }

        private void Qitem_QuestionEdited(UCExamQuestionListItem item, IQuestion question)
        {
            item.init(question.RegisterTime.ToLocalTime().ToPrettyTime());
        }

        private void SelectedQitem_CheckedChange(UCExamQuestionListItem item, IQuestion question)
        {
            if (!item.Checked)
            
            {
                if (MessageBox.Show("آیا میخواهید این پرسش حذف شود؟", "حذف پرسش", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    flpSelectedQuestions.Controls.Remove(item);
                    Questions.Remove(question);
                    totalMark -= question.Score;
                    lblTotalMark.Text = totalMark.ToString();
                }
            }
            else
            {
                item.Checked = true;
            }
        }
        private void flpSelectedQuestions_DragDrop(object sender, DragEventArgs e)
        {
            var data = (UCQuestionListItem)e.Data.GetData(typeof(UCQuestionListItem));

            FlowLayoutPanel _source = (FlowLayoutPanel)data.Parent;
            if (flpSelectedQuestions == _source)
            {
                Point p = flpSelectedQuestions.PointToClient(new Point(e.X, e.Y));
                var item = flpSelectedQuestions.GetChildAtPoint(p);
                int index = flpSelectedQuestions.Controls.GetChildIndex(item, false);

                flpSelectedQuestions.Controls.SetChildIndex(data, index);
                RefreshNumberInFlpSelected();
                flpSelectedQuestions.Invalidate();


            }
        }
        private void flpSelectedQuestions_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flpSelectedQuestions_DragOver(object sender, DragEventArgs e)
        {

            Point p = flpSelectedQuestions.PointToClient(new Point(e.X, e.Y));
            var item = flpSelectedQuestions.GetChildAtPoint(p);

            int index = flpSelectedQuestions.Controls.GetChildIndex(item, false);
            if (index >= 0)
            {

                if (index > lastIndex && flpSelectedQuestions.Controls.Count > index + 1)
                    flpSelectedQuestions.ScrollControlIntoView(flpSelectedQuestions.Controls[index + 1]);
                else if (index < lastIndex && index > 0)
                    flpSelectedQuestions.ScrollControlIntoView(flpSelectedQuestions.Controls[index - 1]);

                lastIndex = index;
            }
        }
        void RefreshNumberInFlpSelected()
        {
            int i = 1;
            foreach (UCQuestionListItem qitem in flpSelectedQuestions.Controls)
                qitem.Number = i++;
        }

        private void FrmMakeExam_Load(object sender, EventArgs e)
        {
            foreach (var q in Questions)
            {

                var qitem = new UCExamQuestionListItem(q, q.LessonName, flpSelectedQuestions.Controls.Count + 1);
                qitem.HasRemoveButton = false;
                qitem.Width = flpSelectedQuestions.Width - 50;
                qitem.RightToLeft = RightToLeft.Yes;
                qitem.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                qitem.Resize += (s, ev) => { qitem.MaximumSize = new Size(Width - 50, 0); };
                qitem.Name = q.Id;
                qitem.Checked = true;
                qitem.CheckedChange += SelectedQitem_CheckedChange;
                qitem.MouseDown += (s, ev) => { qitem.DoDragDrop(qitem, DragDropEffects.Move); };
                qitem.QuestionEdited += Qitem_QuestionEdited;
                qitem.CausesValidation = false;
                qitem.Cursor = Cursors.Hand;
                qitem.MarkChanged += Qitem_MarkChanged;
                //qitem.AllowDrop = true;
                flpSelectedQuestions.Controls.Add(qitem);
            }
        }

        private void createExamFile_Click(object sender, EventArgs e)
        {
            var invalid = Questions.Any(q=>q.Score==0);
            if(invalid)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "نمره برخی سوالها وارد نشده است";
                return;
            }
            Exam exam = new Exam();
            exam.Id = Guid.NewGuid().ToString();

            var st = faDatePicker1.SelectedDateTime;
            if (st.HasValue)
            {
                var s = st.Value.ToUniversalTime();
                st=PersianDateConverter.ToMiladi(s);
                st = new DateTime(s.Year, s.Month, s.Day,int.Parse(comboStartHour.Text), int.Parse(comboStartMinute.Text),0);
            }
            exam.StartTime = st;
            exam.Time = new TimeSpan(int.Parse(comboHour.Text), int.Parse(comboMinute.Text), 0);
            exam.ExamName = txtName.Text;
            exam.PasswordForExamTime= txtPassword.Text;
            exam.PasswordForEvaluationTime = txtEPass.Text;
            int i = 0;
            foreach(var q in Questions)
            {
                exam.AddQuestion(q, i++);
            }
            IFormatter formatter = new BinaryFormatter();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "آزمون پرسان(*.pex)|*.pex";
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(save.FileName,FileMode.Create,FileAccess.Write,FileShare.None);
                //MemoryStream ms = new MemoryStream();
                RijndaelManaged rmCrypto = new RijndaelManaged();
                byte[] key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] iv = { 0x08, 0x07, 0x06, 0x05, 0x04, 0x03, 0x02, 0x01, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                //Create a CryptoStream, pass it the NetworkStream, and encrypt   
                //it with the Rijndael class.  
                CryptoStream cryptStream = new CryptoStream(fileStream,rmCrypto.CreateEncryptor(key, iv),CryptoStreamMode.Write);
                formatter.Serialize(cryptStream,exam);


                cryptStream.Close();
                fileStream.Close();
            }
        }

       

        private void FrmMakeExam_SizeChanged(object sender, EventArgs e)
        {
            panel2.Width = Width - panel1.Width;
            MinimumSize = Size;
        }
    }
}
