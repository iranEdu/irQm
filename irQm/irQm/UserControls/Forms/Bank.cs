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
            using (var db = new irQmDbContext())
            {
                IQuestion[] questions=null;
                FlowLayoutPanel target = null;
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        questions =  db.MultiChoicesQuestions.ToArray();
                        target = flpMultiOptionsQuestions;
                        break;
                    case 1:
                        questions = db.TFQuestions.ToArray();
                        target = flpTFQuestions;
                        break;
                    case 2:
                        questions = db.PuzzleQuestions.ToArray();
                        target = flpPuzzleQuestions;
                        break;
                    case 3:
                        questions = db.ShortAnswerQustions.ToArray();
                        target = flpShortQuestions;
                        break;
                    case 4:
                        questions = db.LongAnswerQuestions.ToArray();
                        target = flpLongQuestions;
                        break;
                    case 5:
                        questions = db.PracticalQuestions.ToArray();
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
    }
}
