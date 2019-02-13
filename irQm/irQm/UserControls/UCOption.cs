using System;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls
{
    public partial class UCOption : UserControl
    {
        public Option Option { get; }
        public delegate void OptionEventHandler(UCOption ucoption);
        public event OptionEventHandler OptionRemoved;
        public event OptionEventHandler CheckedChanged;
        byte _number = 1;
        public byte Number { get { return _number; } set { _number = value;Option.number = value;
                lblNumber.Text = value.ToString(); } }
        bool _checked;
        public bool Checked { get { return _checked; }

            set { _checked = value;
                cbIsTrue.Checked = value;

            } }

        public UCOption(Option option)
        {
            this.Option = option;
            
            InitializeComponent();
            Number=option.number;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Option.number > 1)
            {
                OptionRemoved?.Invoke(this);
                this.Dispose();
            }
        }

        private void rtbOption_TextChanged(object sender, EventArgs e)
        {
            Option.Face = rtbOption.Rtf;
        }

        private void cbIsTrue_CheckedChanged(object sender, EventArgs e)
        {
            
            _checked = cbIsTrue.Checked;
            Option.IsTrue = _checked;
            if (_checked)
                this.BackColor = BaseCodes.Utilities.Globals.Colors.TrueOption ;
            else
                this.BackColor = System.Drawing.Color.FromArgb(0, 187, 236, 179);

            CheckedChanged?.Invoke(this);

        }

        private void pbEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
