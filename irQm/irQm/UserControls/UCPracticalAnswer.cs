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
       
        public  List<StringItem> CheckList { get; set; }
        public UCPracticalAnswer()
        {
            InitializeComponent();
           
            CheckList = ucPracticalItemList1.Items;
        }

        public void New(List<StringItem> checkList)
        {
            CheckList = checkList;
            ucPracticalItemList1.Items = checkList;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            ucPracticalItemList1.AddOption(new BaseCodes.StringItem());
          
        }

        
    }
}
