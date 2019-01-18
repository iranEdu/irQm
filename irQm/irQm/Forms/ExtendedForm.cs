using System;
using System.Windows.Forms;

namespace irQm.Forms
{
    public class ExtendedForm:Form
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
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Name = "ExtendedForm";
            this.ResumeLayout(false);

        }
    }
}
