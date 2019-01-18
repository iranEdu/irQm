using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Linq;
using irQm.BaseCodes;

namespace irQm.Forms
{
    public partial class FrmLogin : ExtendedForm
    {
        public FrmLogin()
        {
            InitializeComponent();
           

        }

      

        private void Btnentire_Click(object sender, EventArgs e)
        {
            using (irQmDbContext db = new irQmDbContext())
            {
                var user = db.User.FirstOrDefault(u => u.UserName == txtusername.Text.ToLower().Trim() && u.Password == txtpass.Text.GetHashCode().ToString());
                if (user!=null)
                {
                    FrmMain main = new FrmMain();
                    irQm.BaseCodes.Utilities.Globals.CurrentUser = user;
                    main.Show();
                    this.Close();
                }
            }

        }

        private void Picexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Picimg_Click(object sender, EventArgs e)
        {
           
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUserRegister reg = new FrmUserRegister();
            reg.ShowDialog();
           
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtusername.Select();
        }
    }
}
