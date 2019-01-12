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
    public partial class UCMultiOptionsForPresentation : UserControl
    {
        [DesignOnly(true)]
        public UCMultiOptionsForPresentation()
        {
            InitializeComponent();
        }
        public UCMultiOptionsForPresentation(List<Option> options)
        {
            InitializeComponent();
            if (options == null || options.Count == 0)
                return;
            Options = options.OrderBy(o => o.number).ToList();
            flpContent.FlowDirection = FlowDirection.TopDown;
            byte i = 1;
            foreach (Option o in options)
            {
                var oc = new UCOptionForPresentation();
                oc.Option = o;
                oc.Row = i++;
                oc.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
                Controls.Add(oc);

            }
        }
        public List<Option> Options { get;private set; }
        private void Initialize(List<Option> options)
        {
            
            
        }
        public override Color BackColor { get => base.BackColor;
            set
            {
                base.BackColor = value;
                flpContent.BackColor = value;

            }
        }
    }
}
