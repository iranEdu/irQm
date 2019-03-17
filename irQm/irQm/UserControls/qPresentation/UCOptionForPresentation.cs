using System;
using System.Windows.Forms;
using irQm.BaseCodes;
using irQm.UserControls.Utilities;

namespace irQm.UserControls.qPresentation
{
    public partial class UCOptionForPresentation : UserControl
    {
        bool answerTime;
        bool showTrueOption;
        private bool justOneTrueOption;
        public bool Checked
        {
            get
            {
                if (justOneTrueOption)
                    return rbIsTrue.Checked;
                else
                    return cbIsTrue.Checked;
            }
            set
            {
                if (justOneTrueOption)
                    rbIsTrue.Checked=value;
                else
                    cbIsTrue.Checked=value;
            }
        }
        public event OptionForPresentationHandler CheckedChanged;
        public delegate void OptionForPresentationHandler(UCOptionForPresentation sender);
        public UCOptionForPresentation(Option option,bool justOneTrueOption, bool answerTime, bool showTrueOption)
        {
           
            this.justOneTrueOption = justOneTrueOption;
            InitializeComponent();
            this.option = option;
            this.answerTime = answerTime;
            this.showTrueOption = showTrueOption;
            FRtbFace.Rtf = option.Face;
            lblNumber.Text = option.number.ToString();

            if (justOneTrueOption)
            {
                rbIsTrue.Visible = true;
                cbIsTrue.Visible = false;
            }
            else
            {
                rbIsTrue.Visible = false;
                cbIsTrue.Visible = true;
            }
            if (answerTime)
            {
                cbIsTrue.Checked = option.Answered;
                rbIsTrue.Checked = option.Answered;

                if (showTrueOption)
                {
                    if (option.IsTrue)
                    {
                        BackColor = BaseCodes.Utilities.Globals.Colors.TrueOption;
                    }

                    AlphaPanel alphaPanel = new AlphaPanel();
                    alphaPanel.Dock = DockStyle.Fill;
                    this.Controls.Add(alphaPanel);
                    alphaPanel.BringToFront();

                }

            }

            else
            {

                cbIsTrue.Checked = option.IsTrue;
                rbIsTrue.Checked = option.IsTrue;
                AlphaPanel alphaPanel = new AlphaPanel();
                alphaPanel.Dock = DockStyle.Fill;
                this.Controls.Add(alphaPanel);
                alphaPanel.BringToFront();

            }
            //   FRtbFace.BackColor = Color.Transparent;
        }
        Option option;
        

        //public Option Option
        //{
        //    get { return option; }
        //    set
        //    {
        //        option = value;

        //    }
        //}
        //public byte Row
        //{
        //    get { return byte.Parse(lblNumber.Text); }
        //    set { lblNumber.Text = Row.ToString(); }
        //}

        private void cbIsTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (answerTime)
                if (cbIsTrue.Checked)
                {
                    option.Answered = true;
                    
                }
                else
                    option.IsTrue = true;
            

        }

        private void rbIsTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (answerTime)
                if (cbIsTrue.Checked)
                    option.Answered = true;
                else
                    option.IsTrue = true;
            CheckedChanged?.Invoke(this);
        }
    }
}
