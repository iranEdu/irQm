using System;
using System.Drawing;
using System.Windows.Forms;
using irQm.BaseCodes;
using irQm.Forms;

namespace irQm.UserControls.qPresentation
{
    public partial class UCQuestionListItem : UserControl
    {
        public delegate void UCQuestionListItemEHndler(UCQuestionListItem item, IQuestion question);
        public event UCQuestionListItemEHndler Removed;
        public event UCQuestionListItemEHndler CheckedChange;
        public event UCQuestionListItemEHndler QuestionEdited;

        int _number;
        IQuestion Question;
  

        public Color SubtitleColor
        {
            get { return lblSubtitle.BackColor; }
            set { lblSubtitle.BackColor = value; }
        }
        public bool Checked
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

        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                lblNumber.Text = value.ToString();
            }
        }
        public UCQuestionListItem(IQuestion question, string subtitle, int number)
        {

            InitializeComponent();
            
            _number = number;
            Question = question;
            init(subtitle);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public void init(string subtitle)
        {
            
            lblSubtitle.Text = subtitle;
            lblNumber.Text = _number.ToString();
            faceBox.Rtf = Question.Face;
            if (faceBox.Text.Length > 50)
            {
                var s = faceBox.Text.Substring(0, 50);
                faceBox.Text += s + "...";
            }
        }

        public UCQuestionListItem()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            lblSubtitle.MaximumSize = new Size(new Point(Width-30,0));

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
        protected override void OnPaint(PaintEventArgs e)
        {
           
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(Brushes.DarkGray, 1), 0, Height - 1, Width, Height - 1);

        }

        private void showQuestion_Click(object sender, EventArgs e)
        {
            FrmQuestion frmQuestion = new FrmQuestion(Question, true,false);
            frmQuestion.ShowDialog();
            if (frmQuestion.IsEdited)
                QuestionEdited?.Invoke(this, Question);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmQuestion frmQuestion = new FrmQuestion(Question, true, true);
            frmQuestion.ShowDialog();
            if (frmQuestion.IsEdited)
                QuestionEdited?.Invoke(this, Question);
        }
    }
}
