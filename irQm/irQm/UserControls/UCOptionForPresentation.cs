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

namespace irQm.UserControls
{
    public partial class UCOptionForPresentation : UserControl
    {
        public UCOptionForPresentation()
        {
            InitializeComponent();
         //   FRtbFace.BackColor = Color.Transparent;
        }
        Option option;
        public Option Option
        {
            get { return option; }
            set
            {
                option = value;
                FRtbFace.Rtf = option.Face;
                lblNumber.Text = option.number.ToString();
                cbIsTrue.Checked = option.Answered;
            }
        }
        public byte Row
        {
            get { return byte.Parse(lblNumber.Text); }
            set { lblNumber.Text = Row.ToString(); }
        }

        private void cbIsTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsTrue.Checked)
                option.Answered = true;
            else
                option.Answered = true;
        }
    }
}
