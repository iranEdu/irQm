using System;
using System.Windows.Forms;

namespace irQm.Forms
{
    public abstract class ExtendedForm:Form
    {

        public ExtendedForm():base()
        { InitializeComponent(); }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ExtendedForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 504);
            this.Name = "ExtendedForm";
            this.ResumeLayout(false);

        }
    }
}
