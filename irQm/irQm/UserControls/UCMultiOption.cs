
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
    public partial class UCMultiOption : UserControl
    {
       
       public List<Option> Options;


        public UCMultiOption()
        {
            InitializeComponent();
            
            Options =ucOptionList1.Options;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
             ucOptionList1.AddOption(new BaseCodes.Option());
        }

        private void cbMulti_CheckedChanged(object sender, EventArgs e)
        {
            if(!cbMulti.Checked&&Options.Count(o=>o.IsTrue)>1 )
            {
                cbMulti.Checked = true;
                MessageBox.Show("بیش از دو گزینه به عنوان پاسخ تیک خورده است! \n برای فعال کردن تک انتخابی، ابتدا گزینه‌های اضافی را از حالت پاسخ در بیاورید", "خطا!");
                return;
            }
            ucOptionList1.MultiSelect = cbMulti.Checked;
           
        }

        public void New(List<Option> options)
        {
            ucOptionList1.New(options);
            Options = options;
        }
    }
}
