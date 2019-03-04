using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.Forms
{
    public partial class UserEditForm : MasterForm
    {
        public UserEditForm()
        {
            InitializeComponent();
        }

        private void BtnEntire_Click(object sender, EventArgs e)
        {
            


        }

        private void Picexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Picimg_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
    

