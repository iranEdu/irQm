using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        internal new static void Show()
        {
            throw new NotImplementedException();
        }

        private void Label13_Click(object sender, EventArgs e)
        {
            Frmnewlesson Fnl = new Frmnewlesson();
            Fnl.Show();
        }
    }
}
