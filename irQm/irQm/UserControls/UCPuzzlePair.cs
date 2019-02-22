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

namespace irQm
{
    public partial class UCPuzzleOption : UserControl
    {
        public StringPair Pair { get; private set; }
        public delegate void StringPairEventHandler(UCPuzzleOption ucpuzzleoption);
        public event StringPairEventHandler PairRemoved;
        byte _number = 1;
        public byte Number
        {
            get { return _number; }
            set
            {
                _number = value; Pair.Number = value;
                lblNumber.Text = value.ToString();
            }

        
        
            }
        public UCPuzzleOption(StringPair pair)
        {
            this.Pair = pair;
            InitializeComponent();
            Number = pair.Number;
        }



        private void pbRemove_Click(object sender, EventArgs e)
        {
            if (Pair.Number > 1)
            {
                PairRemoved?.Invoke(this);
                this.Dispose();
            }
        }

        private void txtcolumn1_TextChanged(object sender, EventArgs e)
        {
            Pair.Key= textFirstpair.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            Pair.Value = TextSecondpair.Text;
        }
    }
}
