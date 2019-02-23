using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.UserControls
{
    public partial class UCRadiobutton : UserControl
    {
        public UCRadiobutton()
        {
            InitializeComponent();
            AddRadioButton();
        }
        public bool check { get; set; }
        private void AddRadioButton()
        {
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == false)
            {
                pictureBox2.Visible = true;
                pictureBox2.BringToFront();
                check = true;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                check = false;
            }
        }
    }
    
}
