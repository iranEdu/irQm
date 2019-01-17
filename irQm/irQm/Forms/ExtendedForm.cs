using System;
using System.Windows.Forms;

namespace irQm.Forms
{
    public class ExtendedForm:Form
    {
        public ExtendedForm():base()
        { }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }
    }
}
