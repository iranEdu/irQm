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
        { IQuestion[] questions;
            using (var db = new irQmDbContext())
            {
                questions = db.TFQuestions.ToArray();
                questions.Union(db.MultiChoicesQuestions);
                questions.Union(db.PuzzleQuestions);
            }
            int i = 1;

            foreach (var q in questions.OrderBy(q => q.Face))
            {
                var qitem = new UCQuestionListItem(q, "سیی", i);
                qitem.Width = flpQuestions.Width - 50;
                qitem.RightToLeft = RightToLeft.Yes;
                qitem.Anchor = AnchorStyles.Right | AnchorStyles.Left;
                qitem.Resize += (s, ev) => { qitem.MaximumSize = new Size(Width - 50, 0); };
                flpQuestions.Controls.Add(qitem);
                list.Add(qitem);
                i++;
            }

        }
    }
}
