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
    public partial class UCStringItem : UserControl
    {
        public StringItem Item { get; }
        public delegate void OptionEventHandler(UCStringItem ucStringItem);
        public event OptionEventHandler ItemRemoved;
        byte _number = 1;
        public byte Number
        {
            get { return _number; }
            set
            {
                _number = value; Item.Number = value;
                lblNumber.Text = value.ToString();
            }
        }
        public UCStringItem(StringItem item)
        {
            this.Item = item;
            InitializeComponent();
            Number = item.Number;
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            if (Item.Number > 1)
            {
                ItemRemoved?.Invoke(this);
                this.Dispose();
            }
        }

        private void txtCheckList_TextChanged(object sender, EventArgs e)
        {
            Item.Value =textCheckList.Text;
        }
    }
}
