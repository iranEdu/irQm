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
    public partial class UCOptionPractical : UserControl
    {
        public Option Option { get; }
        public delegate void OptionEventHandler(UCOptionPractical  ucoptionpractical);
        public event OptionEventHandler OptionRemoved;
        byte _number = 1;
        public byte Number
        {
            get { return _number; }
            set
            {
                _number = value; Option.number = value;
                lblNumber.Text = value.ToString();
            }
        }
        public UCOptionPractical(Option option)
        {
            this.Option = option;
            InitializeComponent();
            Number = option.number;
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            if (Option.number > 1)
            {
                OptionRemoved?.Invoke(this);
                this.Dispose();
            }
        }

        private void txtCheckList_TextChanged(object sender, EventArgs e)
        {
            Option.Face =txtCheckList.Rtf;
        }
    }
}
