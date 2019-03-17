using System;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls.qPresentation
{
    public partial class LongAnswerForPresentation : UserControl
    {

        bool answerTime;
        bool showAnswer;
        public LongAnswerForPresentation(LongAnswer question , bool answerTime,bool showAnswer)
        {
            this.answerTime = answerTime;
            this.showAnswer = showAnswer;
            var ans = question.Answer;
            var uAns = question.UserAnswer;

            InitializeComponent();
            if(answerTime)
            {
                txtAnswer.Text = uAns;
                txtAnswer.ReadOnly = false;
                if (showAnswer)
                {
                    txtAnswer.ReadOnly = true;
                    var lbl = new Label();
                        lbl.Width = flowLayoutPanel1.Width;
                        lbl.Text = ans;
                        lbl.AutoSize = true;
                        flowLayoutPanel1.Controls.Add(lbl);

                    
                }
            }
            else
            {
                txtAnswer.Visible = false;
                var lbl = new Label();
                lbl.Width = flowLayoutPanel1.Width;
                lbl.Text = ans;
                lbl.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lbl);
            }
           
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            txtAnswer.Width = flowLayoutPanel1.Width-10;
            if(answerTime)
                if(showAnswer)
                    txtAnswer.Height =(int) (0.6 * flowLayoutPanel1.Height);
            else
                    txtAnswer.Height = flowLayoutPanel1.Height-10;

            else
                txtAnswer.Height = 0;


        }
    }
}
