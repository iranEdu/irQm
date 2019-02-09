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
using System.IO;

namespace irQm
{
    public partial class UCQuestionForPresentation : UserControl
    {
        private IQuestion _question;

        public IQuestion Question { get => _question; set { _question = value;InitializeAnswerZone(); } }


        public UCQuestionForPresentation(IQuestion question)
        {
            InitializeComponent();
            _question = question;
            InitializeAnswerZone();
        }

        public UCQuestionForPresentation()
        {
            InitializeComponent();
            _question = new MultiChoices();

            InitializeAnswerZone();
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
            //flowLayoutPanel1.Controls.;
            if (Question is MultiChoices)
            {
                UserControls.MultiOptionsForPresentation multiOptionsForPresentation1;

                multiOptionsForPresentation1 = new irQm.UserControls.MultiOptionsForPresentation((Question as MultiChoices).Options);
                multiOptionsForPresentation1.Width = Width-10;
                
                // 
                // ucMultiOptionsForPresentation1
                // 
             

                flowLayoutPanel1.Controls.Add(multiOptionsForPresentation1);
            }
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
           
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                c.Width = flowLayoutPanel1.Width-10;
            }
            if(pictureBox1.Image!=null)
            {
                var img = pictureBox1.Image;
                var w = img.Width;
                var h = img.Height;
                pictureBox1.Height = (w / pictureBox1.Width) * h;
            }

        }
    }
}
