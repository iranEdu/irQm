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
    public partial class UCPracticalAnswer : UserControl
    {
        public Practical Question { get; set; }
        List<Option> options;
        public UCPracticalAnswer()
        {
            InitializeComponent();
            Question = new Practical();
            options = ucOptionListPracical1.Options;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            ucOptionListPracical1.AddOption(new BaseCodes.Option());
          
        }

        
    }
}
