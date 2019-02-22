using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Linq;
using irQm.BaseCodes;
using irQm.Properties;
using irQm.UserControls.Forms;

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

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtusername.Text)||string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("نام یا رمز عبور خالی است", "ورود نادرست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (irQmDbContext db = new irQmDbContext())
            {
                var user = db.User.FirstOrDefault(u => u.UserName == txtusername.Text.ToLower().Trim() && u.Password == txtpass.Text.GetHashCode().ToString());
                if (user!=null)
                {
                    MasterForm main = new MasterForm();
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
                else
                {
                    MessageBox.Show("نام یا رمز عبور نادرست است", "ورود نادرست", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var reg = new UserRegister();
            panel1.Controls.Add(reg);
           
            reg.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            reg.Width = panel1.Width;
            reg.BringToFront();
           
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtusername.Select();
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtusername.Text != null)
            {

                this.btnLogin.PerformClick();

            }
           
            }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txtpass.Text != null)
            {
                //SendKeys.Send("{TAB}");
                this.btnLogin.PerformClick();


            }
            
        }
    }
}
