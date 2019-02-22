using System.Collections.Generic;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls.qPresentation
{
    public partial class PracticalForPresentation : UserControl
    {
        public PracticalForPresentation(ICollection<StringItem> items)
        {
            InitializeComponent();
            var c = 1;
            foreach (var i in items)
            {

                var lbl = new Label();
                lbl.Width = flowLayoutPanel1.Width;
                lbl.Text = c.ToString()+". "+ i.Value;
                lbl.AutoSize = true;
                flowLayoutPanel1.Controls.Add(lbl);
                c++;

            }


        }
    }
}
