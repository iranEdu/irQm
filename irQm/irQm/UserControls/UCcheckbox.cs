using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace irQm.UserControls
{
    public partial class UCCheckbox : UserControl
    {
        private bool _checked;
        private string _text;

        public bool Checked { get => _checked; set { _checked = value; if (_checked) pictureBox1.Image = Properties.Resources.ceck; else pictureBox1.Image = null; CheckedChanged?.Invoke(this, null); } }
        public event EventHandler CheckedChanged;
        [Browsable(false)]
        public new   string Text
        {
            get => _text;
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    label1.Visible = false;
                    Width = pictureBox1.Width;
                    pictureBox1.Dock = DockStyle.Fill;

                }
                else
                {
                    pictureBox1.Dock = DockStyle.None;
                    Width = pictureBox1.Width + label1.Width + 5;
                }
                label1.Text = value;
                _text = value;
            }
        } 

        public UCCheckbox()
        {
            InitializeComponent();

           
        }
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            
            
           
        }

        private void UCCheckbox_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Height = Height;
            label1.MinimumSize = new System.Drawing.Size(0, Height);
            label1.Left = pictureBox1.Right + 5;
        }
    }
}
