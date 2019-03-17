using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls.qPresentation
{
    public partial class ShortAnswerForPresentation : UserControl
    {
       
        List<StringItem> stringItems;
        public ShortAnswerForPresentation(ShortAnswer question , bool answerTime,bool showAnswer)
        {
            this.stringItems = question.Answer;

            InitializeComponent();
            if(answerTime)
            {
                txtAnswer.Text = question.UserAnswer;
                txtAnswer.ReadOnly = false;
                if(showAnswer)
                {
                    foreach (var i in stringItems)
                    {
                        txtAnswer.ReadOnly = true;
                        var lbl = new Label();
                        lbl.Width = flowLayoutPanel1.Width;
                        lbl.Text = i.Value;
                        lbl.AutoSize = true;
                        flowLayoutPanel1.Controls.Add(lbl);
                        

                    }
                }
            }
            else
            {
                txtAnswer.Visible = false;
                foreach (var i in stringItems)
                {
                    var lbl = new Label();
                    lbl.Width = flowLayoutPanel1.Width-10;
                    lbl.Text = i.Value;
                    lbl.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(lbl);

                }
            }
           
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            txtAnswer.Width = flowLayoutPanel1.Width-10;
        }
    }
}
