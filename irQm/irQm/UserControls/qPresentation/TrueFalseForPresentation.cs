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
        TFOption trueOption;
        TFOption falseOption;
        bool answerTime;
        bool showTrueOption;
        public TrueFalseForPresentation(TFOption trueOption,TFOption falseOption,bool answerTime,bool showTrueOption)
        {
            InitializeComponent();
            this.answerTime = answerTime;
            this.trueOption = trueOption;
            this.falseOption = falseOption;

            this.showTrueOption = showTrueOption;
            if (answerTime)
            {
                chbTrue.Checked = trueOption.Answered;
                chbFalse.Checked = falseOption.Answered;
               
                if (showTrueOption)
                {
                    if (trueOption.IsTrue)
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

                chbTrue.Checked = trueOption.IsTrue;
                chbFalse.Checked = falseOption.IsTrue;
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
            trueOption.Answered = chbTrue.Checked;
            falseOption.Answered = chbFalse.Checked;
        }

        private void chbFalse_CheckedChanged(object sender, EventArgs e)
        {
            trueOption.Answered = chbTrue.Checked;
            falseOption.Answered = chbFalse.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chbTrue.Checked = false;
            chbFalse.Checked = false;
        }
    }
}
