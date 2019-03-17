using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm
{
    public partial class UCTrueFalseAnswer : UserControl
    {
        public bool isTrue
        { get => rbTrue.Checked; set { rbTrue.Checked = value; } }

        public bool isFalse
        { get => rbFalse.Checked; set { rbFalse.Checked = value; } }

        public UCTrueFalseAnswer()
        {
            InitializeComponent();
        }
        public void New()
        {
            rbTrue.Checked = false;
            rbFalse.Checked = false;
         
        }
        public void New(bool isTrue,bool isFalse)
        {
            rbTrue.Checked = isTrue;
            rbFalse.Checked = isFalse;

        }

        private void rbTrue_CheckedChanged(object sender, EventArgs e)
        {
            System.Diagnostics.StackTrace t = new System.Diagnostics.StackTrace();
            Console.WriteLine(t.ToString());
        }
    }
}
