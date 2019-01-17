using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.UserControls.Utilities
{
    public partial class UCMessageBox : UserControl
    {
        public UCMessageBox( Form form)
        {
            InitializeComponent();
            this.Visible = false;
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(100, 50, 50, 50);
            form.Controls.Add(this);
        }

        public void ShowMessage(string message,Color color)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = color;
            this.BringToFront();
            Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
