using System;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls
{
    public partial class UCQuestionListItem : UserControl
    {
        public delegate void RemovedEh(UCQuestionListItem item, IQuestion question);
        public event RemovedEh Removed;

        IQuestion Question;
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


        }
        public UCQuestionListItem()
        {
            InitializeComponent();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            faceBox.Width= flowLayoutPanel1.Width = this.Width;

        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            Removed?.Invoke(this, Question);
        }
    }
}
