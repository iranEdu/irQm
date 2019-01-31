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
    public partial class UCShortAnswer : UserControl
    {
        private List<StringItem> _stringList;

        public List<StringItem> StringList { get => _stringList.Where(i => !string.IsNullOrWhiteSpace(i.Value)).ToList(); set => _stringList = value; }
        public UCShortAnswer()
        {
            InitializeComponent();
            _stringList = ucstringitemList1.Items;
        }
        public void New(List<StringItem> checkList)
        {
            _stringList = checkList;
            ucstringitemList1.Items = checkList;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            ucstringitemList1.AddOption(new BaseCodes.StringItem());

        }
    }
}
