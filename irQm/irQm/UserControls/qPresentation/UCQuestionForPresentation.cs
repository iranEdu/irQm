using System;
using System.Drawing;
using System.Windows.Forms;
using irQm.BaseCodes;
using System.IO;

namespace irQm.UserControls.qPresentation
{
    public partial class UCQuestionForPresentation : UserControl
    {
        private IQuestion _question;


        public IQuestion Question { get => _question;}

        int flpHeight;
       
        public UCQuestionForPresentation()
        {
            InitializeComponent();

        }
        public void Initialize(MultiChoices question, bool answerTime, bool showTrueOption)
        {
            _question = question;
            InitializeAnswerZone();
            MultiOptionsForPresentation ans = new MultiOptionsForPresentation(question.Options,!question.MultiSelections,answerTime,showTrueOption);
            ans.Tag = "AnswerZone";
            ans.Width = Width - 100;
            flowLayoutPanel1.Controls.Add(ans);
        }

     
        public void Initialize(TFQuestion question,bool answerTime,bool showTrueOption)
        {
            _question = question;
            InitializeAnswerZone();
            TrueFalseForPresentation ans = new TrueFalseForPresentation(question.TrueOption,question.FalseOption,question.AnsweredTrueOption,question.AnsweredTrueOption,answerTime,showTrueOption);
            ans.Width = this.Width - 100;
            ans.Tag = "AnswerZone";

            flowLayoutPanel1.Controls.Add(ans);
        }

        public void Initialize(ShortAnswer question, bool answerTime, bool showTrueOption)
        {
            _question = question;
            InitializeAnswerZone();
            ShortAnswerForPresentation ans = new ShortAnswerForPresentation(question, answerTime, showTrueOption);
            ans.Width = this.Width-100;
            ans.Tag = "AnswerZone";

            flowLayoutPanel1.Controls.Add(ans);
        }
        public void Initialize(LongAnswer question, bool answerTime, bool showTrueOption)
        {
            _question = question;
            InitializeAnswerZone();
            LongAnswerForPresentation ans = new LongAnswerForPresentation(question, answerTime, showTrueOption);
            ans.Width = this.Width - 100;
            ans.Tag = "AnswerZone";
            flowLayoutPanel1.Controls.Add(ans);
        }
        public void Initialize(Practical question, bool answerTime, bool showTrueOption)
        {
            _question = question;
            InitializeAnswerZone();
            PracticalForPresentation ans = new PracticalForPresentation(question.CheckList);
            ans.Width = this.Width - 100;
            ans.Tag = "AnswerZone";
            flowLayoutPanel1.Controls.Add(ans);
        }
        public void Initialize(Puzzle question, bool answerTime, bool showTrueOption)
        {
            _question = question;
            InitializeAnswerZone();
            PuzzleForPresentation ans = new PuzzleForPresentation(question,answerTime,showTrueOption);
            ans.Width = this.Width - 100;
            ans.Tag = "AnswerZone";
            flowLayoutPanel1.Controls.Add(ans);
        }
        public override Color BackColor
        {
            get => base.BackColor; set
            {
                base.BackColor = value;

            }
        }

        private void InitializeAnswerZone()
        {
            frtbFace.Rtf = _question.Face;
            if (_question.Image != null)
            {
                using (var ms = new MemoryStream(_question.Image))
                {
                    var img = Image.FromStream(ms);
                    var w = img.Width;
                    var h = img.Height;
                    pictureBox1.Height = (w / pictureBox1.Width) * h;
                    pictureBox1.Image = img;
                }
            }
           if (flowLayoutPanel1.Controls.Count==4)
            {
                flowLayoutPanel1.Controls.RemoveAt(3);
            }
           
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
        
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                c.Width = flowLayoutPanel1.Width-10;
                if(c.Tag!=null&&c.Tag.Equals("AnswerZone"))
                {

                    c.Height += flowLayoutPanel1.Height - flpHeight;
                    //System.Diagnostics.Debug.WriteLine("{0},{1},{2}",c.Height,flowLayoutPanel1.Height,flpHeight);
                }
               
            }
            if(pictureBox1.Image!=null)
            {
                var img = pictureBox1.Image;
                var w = img.Width;
                var h = img.Height;
                pictureBox1.Height = (w / pictureBox1.Width) * h;
            }
            flpHeight = flowLayoutPanel1.Height;
           
        }
    }
}
