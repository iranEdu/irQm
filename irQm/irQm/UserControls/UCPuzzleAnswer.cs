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
    public partial class UCPuzzleAnswer : UserControl
    {
        public Puzzle Question { get; set; }
        List<StringPair> options;
        public UCPuzzleAnswer()
        {
            InitializeComponent();
            Question = new Puzzle();
            options = ucOptionListpuzzle1.Options;
        }

       
        private void pbAdd_Click(object sender, EventArgs e)
        {
            ucOptionListpuzzle1.AddPair(new StringPair());
        }
    }
}
