using System;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls.qPresentation
{
    public partial class UCQuestionListItem : UserControl
    {
        public delegate void UCQuestionListItemEHndler(UCQuestionListItem item, IQuestion question);
        public event UCQuestionListItemEHndler Removed;
        public event UCQuestionListItemEHndler CheckedChange;
        IQuestion Question;
        public bool Chacked
        {
            get
            {
                return cbSelect.Checked;
            }
            set
            {
                cbSelect.Checked = value;
            }
        }
        public bool HasInformation
        {
            get
            {
                return pbInformation.Visible;
            }
            set
            {
                pbInformation.Visible = value;
            }
        }
        public bool HasRemoveButton
        {
            get
            {
                return pbRemove.Visible;
            }
            set
            {
                pbRemove.Visible = value;
            }
        }
        public bool HasCheckBox
        {
            get
            {
                return cbSelect.Visible;
            }
            set
            {
                cbSelect.Visible = value;
            }
        }
        public UCQuestionListItem(IQuestion question, string subtitle, int number)
        {

            InitializeComponent();
            Question = question;
            lblSubtitle.Text = subtitle;
            lblNumber.Text = number.ToString();
            faceBox.Rtf = question.Face;
            if (faceBox.Text.Length > 50)
            {
                var s = faceBox.Text.Substring(0,50);
                faceBox.Text += s+"...";
            }
        }
        public UCQuestionListItem()
        {
            InitializeComponent();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            

        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            Removed?.Invoke(this, Question);
        }

        private void cbSelect_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChange?.Invoke(this, Question);
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            faceBox.Width = Width-30 ;
        }
    }
}
