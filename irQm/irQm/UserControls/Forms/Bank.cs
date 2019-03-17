using FarsiLibrary.Utils;
using irQm.BaseCodes;
using irQm.Forms;
using irQm.UserControls.qPresentation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace irQm.UserControls.Forms
{
    public partial class Bank : UserControl
    { List<UCQuestionListItem> list=new List<UCQuestionListItem>();
        List<IQuestion> selectedQuestions = new List<IQuestion>();
        RichTextBox rtb = new RichTextBox();
        private string searchExpr;
        private string lessonName;
        private DateTime? fromDate;
        private DateTime? toDate;
        private string[] tags;
        private int lastIndex;

        public Bank()
        {
            PersianDate persianDate = PersianDate.Now;
            FarsiLibrary.Localization.FALocalizeManager.Instance.CustomCulture = new CultureInfo("fa-IR");
            FarsiLibrary.Localization.FALocalizeManager.Instance.CustomLocalizer = new FarsiLibrary.Localization.FALocalizer();
            

            InitializeComponent();
            //create an instance of culture
            //CultureInfo info = new CultureInfo("fa-Ir");
            ////set Persian option to specified culture
            //info.DateTimeFormat.Calendar = new PersianCalendar();

            //Thread.CurrentThread.CurrentCulture = info;
            fdpFrom.SelectedDateTime = persianDate;
            fdpTo.SelectedDateTime = persianDate;
            fdpFrom.SelectedDateTime = null;
            lessonsComboBox1.LoadItems();
            tags = tagsBox1.Tags;
            

        }
        
        private void flpQuestions_SizeChanged(object sender, EventArgs e)
        {
          
            //foreach (var c in list)
            //    c.Width = flpQuestions.Width - 10;
            //Refresh();
        }

       

        private void FrmBank_Load(object sender, EventArgs e)
        {
          

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Controls[0].Controls.Count > 0)
                return;
            
            search();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchExpr = txtSearchExpr.Text;
            lessonName = lessonsComboBox1.Text;

            fromDate = fdpFrom.SelectedDateTime == null ? (DateTime?)null : PersianDateConverter.ToMiladi(fdpFrom.SelectedDateTime);
            toDate = fdpTo.SelectedDateTime == null ? (DateTime?)null : PersianDateConverter.ToMiladi(fdpTo.SelectedDateTime);
            tags = tagsBox1.Tags;

            flpLongQuestions.Controls.Clear();
            flpMultiOptionsQuestions.Controls.Clear();
            flpPracticalQuestions.Controls.Clear();
            flpPuzzleQuestions.Controls.Clear();
            flpShortQuestions.Controls.Clear();
            flpTFQuestions.Controls.Clear();

            search();
        }

        public void search()
        {
            
            if (toDate != null)
            {
                toDate.Value.AddHours(-1* toDate.Value.Hour).AddHours(24);
            }
            System.Diagnostics.Debug.WriteLine(PersianDateConverter.ToMiladi(fdpTo.SelectedDateTime).Year);
           
            using (var db = new irQmDbContext())
            {
                IQuestion[] questions = null;
                FlowLayoutPanel target = null;
                
                switch (tabControl1.SelectedIndex)
                {
                    case 0:


                        questions = db.MultiChoicesQuestions.Where(q => (string.IsNullOrWhiteSpace(lessonName) ? true : q.LessonName == lessonName) && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true)
                  && tags.All(tg => db.TagInMultichoices.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).Include(q=>q.Options).Include(q => q.Tags).ToArray();
                        target = flpMultiOptionsQuestions;
                        break;
                    case 1:
                        
                            questions = db.TFQuestions.Where(q => (string.IsNullOrWhiteSpace(lessonName) ? true : q.LessonName == lessonName) && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true)
                            && tags.All(tg => db.TagInTfQuestion.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).Include(q => q.Tags).ToArray();
                        target = flpTFQuestions;
                        break;
                    case 2:
                       
                            questions = db.PuzzleQuestions.Where(q => (string.IsNullOrWhiteSpace(lessonName) ? true : q.LessonName == lessonName) && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true) 
                            && tags.All(tg => db.TagInPuzzle.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).Include(q=>q.Pairs).Include(q => q.Tags).ToArray();
                        target = flpPuzzleQuestions;
                        break;
                    case 3:
                       
                            questions = db.ShortAnswerQustions.Where(q => (string.IsNullOrWhiteSpace(lessonName) ? true : q.LessonName == lessonName) && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true) 
                            && tags.All(tg => db.TagInShortAnswer.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).Include(q=>q.Answer).Include(q => q.Tags).ToArray();
                        target = flpShortQuestions;
                        break;
                    case 4:
                       
                            questions = db.LongAnswerQuestions.Where(q => (string.IsNullOrWhiteSpace(lessonName) ? true : q.LessonName == lessonName) && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true) &&
                            tags.All(tg => db.TagInLongAnswer.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).Include(q => q.Tags).ToArray();
                        target = flpLongQuestions;
                        break;
                    case 5:
                       
                            questions = db.PracticalQuestions.Where(q => (string.IsNullOrWhiteSpace(lessonName) ? true : q.LessonName == lessonName) && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true) &&
                            tags.All(tg => db.TagInPractical.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).Include(q=>q.Tags).Include(q=>q.CheckList).ToArray();
                        target = flpPracticalQuestions;
                        break;
                    case 6:
                        return;

                }


                int i = 1;
                target.Controls.Clear();
                foreach (var q in questions.OrderBy(q => q.Face))
                {
                    var qitem = new UCQuestionListItem(q, q.RegisterTime.ToLocalTime().ToPrettyTime(), i);
                    qitem.Width = multiTabPage.Width - 50;
                    qitem.RightToLeft = RightToLeft.Yes;
                    qitem.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                    qitem.Resize += (s, ev) => { qitem.MaximumSize = new Size(Width - 50, 0); };
                    qitem.Removed += Qitem_Removed;
                    qitem.CheckedChange += Qitem_CheckedChange;
                    qitem.Name = q.Id;
                    if (selectedQuestions.Contains(q))
                        qitem.Checked = true;
                    target.Controls.Add(qitem);
                    qitem.QuestionEdited += Qitem_QuestionEdited;
                    list.Add(qitem);
                    i++;
                }

            }

        }

        private void Qitem_QuestionEdited(UCQuestionListItem item, IQuestion question)
        {
            item.init(question.RegisterTime.ToLocalTime().ToPrettyTime());
        }

        private void Qitem_Removed(UCQuestionListItem item, IQuestion question)
        {
            if (MessageBox.Show("آیا میخواهید این پرسش از پایگاه پرسشها حذف شود؟", "حذف پرسشها", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                question.DeleteFromDb();
                search();
                if (item.Checked)
                {
                    var controls = flpSelectedQuestions.Controls;
                    controls.Remove(controls.Find(question.Id, false)[0]);
                    selectedQuestions.Remove(question);
                    RefreshNumberInFlpSelected();
                }
            }

        }

        private void Qitem_CheckedChange(UCQuestionListItem item, IQuestion question)
        {
            if (item.Checked)
            {
                var q = question.Clone();
                var qitem = new UCQuestionListItem(q, question.RegisterTime.ToLocalTime().ToPrettyTime(), flpSelectedQuestions.Controls.Count + 1);
                qitem.HasRemoveButton = false;
                qitem.Width = multiTabPage.Width - 50;
                qitem.RightToLeft = RightToLeft.Yes;
                qitem.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                qitem.Resize += (s, ev) => { qitem.MaximumSize = new Size(Width - 50, 0); };
                qitem.Name = question.Id;
                qitem.Checked = true;
                qitem.CheckedChange += SelectedQitem_CheckedChange;
                qitem.MouseDown += (s, ev) => { qitem.DoDragDrop(qitem,DragDropEffects.Move); };
                qitem.QuestionEdited += Qitem_QuestionEdited;
                qitem.CausesValidation = false;
                qitem.Cursor = Cursors.Hand;
                item.Tag = q;
                //qitem.AllowDrop = true;
                flpSelectedQuestions.Controls.Add(qitem);
                selectedQuestions.Add(q);

                list.Add(qitem);
            }
            else if(selectedQuestions.Contains((IQuestion)item.Tag) )
            {
                var q = (IQuestion)item.Tag;
                var controls = flpSelectedQuestions.Controls;
                controls.Remove(controls.Find(question.Id, false)[0]);
                selectedQuestions.Remove(q);
                item.Tag = null;
                RefreshNumberInFlpSelected();
            }
        }

       

        private void SelectedQitem_CheckedChange(UCQuestionListItem item, IQuestion question)
        {
            if (item.Checked)
                return;
            if (MessageBox.Show("آیا میخواهید این پرسش از فهرست انتخاب ‌‌شده‌ها حذف شود؟", "حذف از فهرست", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flpSelectedQuestions.Controls.Remove(item);
                selectedQuestions.Remove(question);
                RefreshNumberInFlpSelected();
                if (question is TFQuestion)
                {
                    var controls = flpTFQuestions.Controls;
                    var f = controls.Find(item.Name, false);

                    if (f.Length > 0)
                    {
                        var c = ((UCQuestionListItem)f[0]);
                        c.Checked = false;
                        c.Tag=null;
                       
                    }
                   
                    
                }
                else if (question is MultiChoices)
                {
                    var controls = flpMultiOptionsQuestions.Controls;
                    var f = controls.Find(item.Name, false);
                    if (f.Length > 0)
                    {
                        var c = ((UCQuestionListItem)f[0]);
                        c.Checked = false;
                        c.Tag = null;

                    }
                }
                else if (question is Puzzle)
                {
                    var controls = flpPuzzleQuestions.Controls;
                    var f = controls.Find(item.Name, false);
                    if (f.Length > 0)
                    {
                        var c = ((UCQuestionListItem)f[0]);
                        c.Checked = false;
                        c.Tag = null;

                    }
                }
                else if (question is ShortAnswer)
                {
                    var controls = flpShortQuestions.Controls;
                    var f = controls.Find(item.Name, false);
                    if (f.Length > 0)
                    {
                        var c = ((UCQuestionListItem)f[0]);
                        c.Checked = false;
                        c.Tag = null;

                    }
                }
                else if (question is LongAnswer)
                {
                    var controls = flpLongQuestions.Controls;
                    var f = controls.Find(item.Name, false);
                    if (f.Length > 0)
                    {
                        var c = ((UCQuestionListItem)f[0]);
                        c.Checked = false;
                        c.Tag = null;

                    }
                }
                else if (question is Practical)
                {
                    var controls = flpPracticalQuestions.Controls;
                    var f = controls.Find(item.Name, false);
                    if (f.Length > 0)
                    {
                        var c = ((UCQuestionListItem)f[0]);
                        c.Checked = false;
                        c.Tag = null;

                    }
                }
            }
            else
                item.Checked = true;
        }

        bool richContains(string rich,string expr)
        {
            if (string.IsNullOrWhiteSpace(expr))
               return true;
       
            rtb.Rtf = rich;
            return rtb.Text.Contains(expr);
        }
        void RefreshNumberInFlpSelected()
        {
            int i = 1;
            foreach (UCQuestionListItem qitem in flpSelectedQuestions.Controls)
                qitem.Number = i++;
        }

        private void flpSelectedQuestions_DragDrop(object sender, DragEventArgs e)
        {
            var data = (UCQuestionListItem)e.Data.GetData(typeof(UCQuestionListItem));
            
            FlowLayoutPanel _source = (FlowLayoutPanel)data.Parent;
            if(flpSelectedQuestions == _source)
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
            if (index >= 0 )
            {
                
                if(index>lastIndex && flpSelectedQuestions.Controls.Count > index + 1)                       
                    flpSelectedQuestions.ScrollControlIntoView(flpSelectedQuestions.Controls[index+1]);
                else if(index < lastIndex &&  index>0)
                    flpSelectedQuestions.ScrollControlIntoView(flpSelectedQuestions.Controls[index - 1]);

                lastIndex = index;
            }
        }

        private void btnMakeExam_Click(object sender, EventArgs e)
        {
            if (selectedQuestions.Count > 0)
            {
                FrmMakeExam f = new FrmMakeExam(selectedQuestions);
                f.ShowDialog();
            }
            else
                MessageBox.Show("پرسشی انتخاب نشده است","توجه!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
