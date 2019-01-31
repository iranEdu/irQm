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
    public partial class UCLongAnswer : UserControl
    {
        public string Answer { get => txtFace.Text.Trim(); set { txtFace.Text = value.Trim(); } }

        public UCLongAnswer()
        {
            InitializeComponent();
        }
        public void New()
        {
            txtFace.Clear();
            txtFace.ClearUndo();
        }
    }
}
