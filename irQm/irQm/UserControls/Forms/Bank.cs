using irQm.BaseCodes;
using irQm.UserControls.qPresentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace irQm.UserControls.Forms
{
    public partial class Bank : UserControl
    { List<UCQuestionListItem> list=new List<UCQuestionListItem>();
        RichTextBox rtb = new RichTextBox();
        private string searchExpr;

        public Bank()
        {
            InitializeComponent();
            
            

        }
        
        private void flpQuestions_SizeChanged(object sender, EventArgs e)
        {
          
            //foreach (var c in list)
            //    c.Width = flpQuestions.Width - 10;
            //Refresh();
        }

       

        private void FrmBank_Load(object sender, EventArgs e)
        { 
            using (var db = new irQmDbContext())
            {
                var multi = db.MultiChoicesQuestions.ToArray();
                int i = 1;
                foreach (var q in multi.OrderBy(q => q.Face))
                {
                    var qitem = new UCQuestionListItem(q, "", i);
                    qitem.Width = multiTabPage.Width - 50;
                    qitem.RightToLeft = RightToLeft.Yes;
                    qitem.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                    qitem.Resize += (s, ev) => { qitem.MaximumSize = new Size(Width - 50, 0); };
                    flpMultiOptionsQuestions.Controls.Add(qitem);
                    list.Add(qitem);
                    i++;
                }
               
            }
            

            

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            search(searchExpr);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchExpr = txtSearchExpr.Text;
            search(searchExpr);
        }

        void search(string expr)
        {
            var tags = tagsBox1.Tags;
            using (var db = new irQmDbContext())
            {
                IQuestion[] questions = null;
                FlowLayoutPanel target = null;
                
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                       
                            questions = db.MultiChoicesQuestions.Where(q => tags.All(tg=>db.TagInMultichoices.Any(t=> t.QuestionId == q.Id&& t.Tag.Value==tg)) && richContains(q.Face,expr)).ToArray();
                        target = flpMultiOptionsQuestions;
                        break;
                    case 1:
                        
                            questions = db.TFQuestions.Where(q => tags.All(tg => db.TagInTfQuestion.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, expr)).ToArray();
                        target = flpTFQuestions;
                        break;
                    case 2:
                       
                            questions = db.PuzzleQuestions.Where(q => tags.All(tg => db.TagInPuzzle.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && q.Face.Contains(expr)).ToArray();
                        target = flpPuzzleQuestions;
                        break;
                    case 3:
                       
                            questions = db.ShortAnswerQustions.Where(q => tags.All(tg => db.TagInShortAnswer.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, expr)).ToArray();
                        target = flpShortQuestions;
                        break;
                    case 4:
                       
                            questions = db.LongAnswerQuestions.Where(q => tags.All(tg => db.TagInLongAnswer.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, expr)).ToArray();
                        target = flpLongQuestions;
                        break;
                    case 5:
                       
                            questions = db.PracticalQuestions.Where(q => tags.All(tg => db.TagInPractical.Any(t => t.QuestionId == q.Id && t.Tag.Value == tg)) && richContains(q.Face, expr)).ToArray();
                        target = flpPracticalQuestions;
                        break;

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
                    target.Controls.Add(qitem);
                    list.Add(qitem);
                    i++;
                }

            }

        }
        bool richContains(string rich,string expr)
        {
            if (string.IsNullOrWhiteSpace(expr))
               return true;
       
            rtb.Rtf = rich;
            return rtb.Text.Contains(expr);
        }
    }
}
