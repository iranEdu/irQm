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

namespace irQm.UserControls.qPresentation
{
    public partial class PracticalForPresentation : UserControl
    {
        public PracticalForPresentation(List<StringItem> items)
        {
            InitializeComponent();

            foreach (var i in items)
            {

                var lbl = new Label();
                lbl.Width = flowLayoutPanel1.Width;
                lbl.Text = i.Value;
                lbl.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lbl);


            }


        }
    }
}
