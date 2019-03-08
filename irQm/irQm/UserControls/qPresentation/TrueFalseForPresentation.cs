using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using irQm.UserControls.Utilities;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls.qPresentation
{
    public partial class TrueFalseForPresentation : UserControl
    {
        bool trueOption;
        bool falseOption;
        bool answeredTrueOption; bool answeredFalseOption;
        bool answerTime;
        bool showTrueOption;

        public bool AnsweredFalseOption1 { get => AnsweredFalseOption2; set => AnsweredFalseOption2 = value; }
        public bool AnsweredFalseOption2 { get => answeredFalseOption; set => answeredFalseOption = value; }

        public TrueFalseForPresentation(bool trueOption,bool falseOption, bool answeredTrueOption, bool answeredFalseOption, bool answerTime,bool showTrueOption)
        {
            InitializeComponent();
            this.answerTime = answerTime;
            this.trueOption = trueOption;
            this.falseOption = falseOption;
            this.AnsweredFalseOption1 = answeredFalseOption;
            this.answeredTrueOption = answeredTrueOption;
            this.showTrueOption = showTrueOption;
            if (answerTime)
            {
                chbTrue.Checked = answeredTrueOption;
                chbFalse.Checked = answeredFalseOption;
               
                if (showTrueOption)
                {
                    if (trueOption)
                    {
                        chbTrue.BackColor = BaseCodes.Utilities.Globals.Colors.TrueOption;
                    }
                    else
                        chbFalse.BackColor = BaseCodes.Utilities.Globals.Colors.TrueOption;
                    AlphaPanel alphaPanel = new AlphaPanel();
                    alphaPanel.Dock = DockStyle.Fill;
                    this.Controls.Add(alphaPanel);
                    alphaPanel.BringToFront();

                }
                else
                    btnClear.Visible = true;
            }

            else
            {

                chbTrue.Checked = trueOption;
                chbFalse.Checked = falseOption;
                AlphaPanel alphaPanel = new AlphaPanel();
                alphaPanel.Dock = DockStyle.Fill;
                this.Controls.Add(alphaPanel);
                alphaPanel.BringToFront();

            }
            this.trueOption = trueOption;
            this.falseOption = falseOption;
        }

        private void chbTrue_CheckedChanged(object sender, EventArgs e)
        {
            answeredTrueOption = chbTrue.Checked;
           AnsweredFalseOption1 = chbFalse.Checked;
        }

        private void chbFalse_CheckedChanged(object sender, EventArgs e)
        {
            answeredTrueOption = chbTrue.Checked;
            AnsweredFalseOption1 = chbFalse.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chbTrue.Checked = false;
            chbFalse.Checked = false;
        }
    }
}
