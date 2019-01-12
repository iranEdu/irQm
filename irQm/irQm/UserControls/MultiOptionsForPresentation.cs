using irQm.BaseCodes;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace irQm.UserControls
{
    public class MultiOptionsForPresentation:FlowLayoutPanel
    {
        List<Option> Options;
        public MultiOptionsForPresentation():base()
        {
            Initialize(null);
        }
        public MultiOptionsForPresentation(List<Option> options):base()
        {
            Initialize(options);
        }
        private void Initialize(List<Option> options)
        {
            if (options == null || options.Count == 0)
                return;
            Options = options.OrderBy(o => o.number).ToList();
            this.FlowDirection = FlowDirection.TopDown;
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

    }
}
