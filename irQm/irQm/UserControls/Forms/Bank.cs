using FarsiLibrary.Utils;
using irQm.BaseCodes;
using irQm.UserControls.qPresentation;
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

        public Bank()
        {
            InitializeComponent();
            //create an instance of culture
            //CultureInfo info = new CultureInfo("fa-Ir");
            ////set Persian option to specified culture
            //info.DateTimeFormat.Calendar = new PersianCalendar();

            //Thread.CurrentThread.CurrentCulture = info;
            PersianDate persianDate = PersianDate.Now;
            FarsiLibrary.Localization.FALocalizeManager.Instance.CustomCulture = new CultureInfo("fa-IR");
            FarsiLibrary.Localization.FALocalizeManager.Instance.CustomLocalizer = new FarsiLibrary.Localization.FALocalizer();
            fdpFrom.SelectedDateTime = persianDate;
            
            fdpTo.SelectedDateTime = persianDate;
            fdpFrom.SelectedDateTime = null;
            lessonsComboBox1.LoadItems();


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
            search();
        }

        public void search()
        {
            
            var fromDate = fdpFrom.SelectedDateTime == null ? (DateTime?)null : PersianDateConverter.ToGregorianDateTime(fdpFrom.SelectedDateTime);
            var toDate = fdpTo.SelectedDateTime == null ? (DateTime?)null : PersianDateConverter.ToGregorianDateTime(fdpTo.SelectedDateTime);
            if (toDate != null)
            {
                toDate.Value.AddHours(-1* toDate.Value.Hour).AddHours(24);
            }
            
            var tags = tagsBox1.Tags;
            using (var db = new irQmDbContext())
            {
                IQuestion[] questions = null;
                FlowLayoutPanel target = null;
                
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                       
                            questions = db.MultiChoicesQuestions.Where(q =>string.IsNullOrWhiteSpace(lessonsComboBox1.Text)?true:q.LessonName==lessonsComboBox1.Text && (fromDate!=null? q.RegisterTime>=fromDate:true) && (toDate != null ? q.RegisterTime <= toDate:true)
                            && tags.All(tg=>db.TagInMultichoices.Any(t=> t.QuestionId == q.Id&& t.Tag.Value==tg)) && richContains(q.Face,searchExpr)).ToArray();
                        target = flpMultiOptionsQuestions;
                        break;
                    case 1:
                        
                            questions = db.TFQuestions.Where(q => string.IsNullOrWhiteSpace(lessonsComboBox1.Text) ? true : q.LessonName == lessonsComboBox1.Text && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true)
                            && tags.All(tg => db.TagInTfQuestion.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).ToArray();
                        target = flpTFQuestions;
                        break;
                    case 2:
                       
                            questions = db.PuzzleQuestions.Where(q => string.IsNullOrWhiteSpace(lessonsComboBox1.Text) ? true : q.LessonName == lessonsComboBox1.Text && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true) 
                            && tags.All(tg => db.TagInPuzzle.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && q.Face.Contains(searchExpr)).ToArray();
                        target = flpPuzzleQuestions;
                        break;
                    case 3:
                       
                            questions = db.ShortAnswerQustions.Where(q => string.IsNullOrWhiteSpace(lessonsComboBox1.Text) ? true : q.LessonName == lessonsComboBox1.Text && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true) 
                            && tags.All(tg => db.TagInShortAnswer.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).ToArray();
                        target = flpShortQuestions;
                        break;
                    case 4:
                       
                            questions = db.LongAnswerQuestions.Where(q => string.IsNullOrWhiteSpace(lessonsComboBox1.Text) ? true : q.LessonName == lessonsComboBox1.Text && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true) &&
                            tags.All(tg => db.TagInLongAnswer.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).ToArray();
                        target = flpLongQuestions;
                        break;
                    case 5:
                       
                            questions = db.PracticalQuestions.Where(q => string.IsNullOrWhiteSpace(lessonsComboBox1.Text) ? true : q.LessonName == lessonsComboBox1.Text && (fromDate != null ? q.RegisterTime >= fromDate : true) && (toDate != null ? q.RegisterTime <= toDate : true) &&
                            tags.All(tg => db.TagInPractical.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, searchExpr)).ToArray();
                        target = flpPracticalQuestions;
                        break;
                    case 6:
                        return;

                }


                int i = 1;
                target.Controls.Clear();
                foreach (var q in questions.OrderBy(q => q.Face))
                {
                    var qitem = new UCQuestionListItem(q, "", i);
                    qitem.Width = multiTabPage.Width - 50;
                    qitem.RightToLeft = RightToLeft.Yes;
                    qitem.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                    qitem.Resize += (s, ev) => { qitem.MaximumSize = new Size(Width - 50, 0); };
                    qitem.Removed += Qitem_Removed;
                    qitem.CheckedChange += Qitem_CheckedChange;
                    qitem.Name = q.Id;
                    if (selectedQuestions.Contains(q))
                        qitem.Chacked = true;
                    target.Controls.Add(qitem);
                    list.Add(qitem);
                    i++;
                }

            }

        }

        private void Qitem_Removed(UCQuestionListItem item, IQuestion question)
        {
            if (MessageBox.Show("آیا میخواهید این پرسش از پایگاه پرسشها حذف شود؟", "حذف پرسشها", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                question.DeleteFromDb();
                search();
                if (item.Chacked)
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
            if (item.Chacked)
            {
                var qitem = new UCQuestionListItem(question, "", flpSelectedQuestions.Controls.Count + 1);
                qitem.HasRemoveButton = false;
                qitem.Width = multiTabPage.Width - 50;
                qitem.RightToLeft = RightToLeft.Yes;
                qitem.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                qitem.Resize += (s, ev) => { qitem.MaximumSize = new Size(Width - 50, 0); };
                qitem.Name = question.Id;
                qitem.Chacked = true;
                qitem.CheckedChange += SelectedQitem_CheckedChange;
                flpSelectedQuestions.Controls.Add(qitem);
                selectedQuestions.Add(question);
                list.Add(qitem);
            }
            else if(selectedQuestions.Contains(question))
            {
                var controls = flpSelectedQuestions.Controls;
                controls.Remove(controls.Find(question.Id, false)[0]);
                selectedQuestions.Remove(question);
                RefreshNumberInFlpSelected();
            }
        }

        private void SelectedQitem_CheckedChange(UCQuestionListItem item, IQuestion question)
        {
            if (item.Chacked)
                return;
            if (MessageBox.Show("آیا میخواهید این پرسش از فهرست انتخاب ‌‌شده‌ها حذف شود؟", "حذف از فهرست", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flpSelectedQuestions.Controls.Remove(item);
                selectedQuestions.Remove(question);
                RefreshNumberInFlpSelected();
                if (question is TFQuestion)
                {
                    var controls = flpTFQuestions.Controls;
                    var f = controls.Find(question.Id, false);
                   
                        if (f.Length > 0)
                            ((UCQuestionListItem)f[0]).Chacked = false; ;
                   
                    
                }
                else if (question is MultiChoices)
                {
                    var controls = flpMultiOptionsQuestions.Controls;
                    var f = controls.Find(question.Id, false);
                    if (f.Length > 0)
                        ((UCQuestionListItem)f[0]).Chacked = false; ;
                }
                else if (question is Puzzle)
                {
                    var controls = flpPuzzleQuestions.Controls;
                    var f = controls.Find(question.Id, false);
                    if (f.Length > 0)
                        ((UCQuestionListItem)f[0]).Chacked = false; ;
                }
                else if (question is ShortAnswer)
                {
                    var controls = flpShortQuestions.Controls;
                    var f = controls.Find(question.Id, false);
                    if (f.Length > 0)
                        ((UCQuestionListItem)f[0]).Chacked = false; ;
                }
                else if (question is LongAnswer)
                {
                    var controls = flpLongQuestions.Controls;
                    var f = controls.Find(question.Id, false);
                    if (f.Length > 0)
                        ((UCQuestionListItem)f[0]).Chacked = false; ;
                }
                else if (question is Practical)
                {
                    var controls = flpPracticalQuestions.Controls;
                    var f = controls.Find(question.Id, false);
                    if (f.Length > 0)
                        ((UCQuestionListItem)f[0]).Chacked = false; ;
                }
            }
            else
                item.Chacked = true;
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

        
    }
}
