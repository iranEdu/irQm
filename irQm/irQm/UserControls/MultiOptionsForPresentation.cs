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
    public partial class MultiOptionsForPresentation : UserControl
    {
        List<Option> Options;
        public MultiOptionsForPresentation()
        {
            InitializeComponent();
            Initialize(null);
        }
        public MultiOptionsForPresentation(List<Option> options)
        {
            InitializeComponent();
            Initialize(options);
        }
        private void Initialize(List<Option> options)
        {
            if (options == null || options.Count == 0)
                return;
            Options = options.OrderBy(o => o.number).ToList();
            
            byte i = 1;
            foreach (Option o in options)
            {
                var oc = new UCOptionForPresentation();
                oc.Option = o;
                oc.Row = i++;
                oc.Width = Width-20;
                flowLayoutPanel1.Controls.Add(oc);

            }
        }

        private void MultiOptionsForPresentation_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                c.Width = flowLayoutPanel1.Width;
            }
        }
    }
}
