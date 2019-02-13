using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls.qPresentation
{
    public partial class MultiOptionsForPresentation : UserControl
    {
        List<Option> Options;
        private bool justOneTrueOption;

        public MultiOptionsForPresentation()
        {
            InitializeComponent();
            Initialize(null);
        }
        public MultiOptionsForPresentation(List<Option> options, bool justOneTrueOption, bool answerTime,bool showTrueOption)
        {
            InitializeComponent();
            this.justOneTrueOption = justOneTrueOption;
            if (options == null || options.Count == 0)
                return;
            Options = options.OrderBy(o => o.number).ToList();

            byte i = 1;
            foreach (Option o in options)
            {
                o.number = i++;
                var oc = new UCOptionForPresentation(o,justOneTrueOption,answerTime,showTrueOption);
                oc.CheckedChanged += Oc_CheckedChanged; ;
               
                oc.Width = Width - 20;
                flowLayoutPanel1.Controls.Add(oc);

            }
        }

        private void Oc_CheckedChanged(UCOptionForPresentation sender)
        {
            if (justOneTrueOption)
            {
                if(sender.Checked)

                foreach (UCOptionForPresentation c in flowLayoutPanel1.Controls)
                {
                  if(c!=sender)
                    c.Checked = false;

                }
               

            }
        }

        private void Initialize(List<Option> options)
        {
           
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
