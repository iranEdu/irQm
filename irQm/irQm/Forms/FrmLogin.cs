using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Linq;
using irQm.BaseCodes;
using irQm.Properties;

namespace irQm.Forms
{
    public partial class FrmLogin : ExtendedForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            if (Settings.Default.passRemember)
            {
                txtpass.Text = Settings.Default.pass;
                txtusername.Text = Settings.Default.username;
                cbRemember.Checked = Settings.Default.passRemember;
            }

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
                    Settings.Default.passRemember = cbRemember.Checked ;
                    if(cbRemember.Checked)
                    {
                        Settings.Default.pass = txtpass.Text;
                        Settings.Default.username = txtusername.Text;
                    }
                    Settings.Default.Save();
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

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtusername.Text != null)
            {

                this.SelectNextControl(this.ActiveControl, true, true, true, true);

            }
            else
            {
                MessageBox.Show("نام کاربری را وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtpass.Text != null)
            {
                //SendKeys.Send("{TAB}");
                this.SelectNextControl(this.ActiveControl, true, true, true, true);

            }
            else
            {
                MessageBox.Show("نام کاربری را وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
