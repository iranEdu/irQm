using System;
using System.Windows.Forms;
using irQm.BaseCodes;
using System.Linq;
using System.Drawing;
using irQm.Forms;

namespace irQm.UserControls.Forms
{
    public partial class UserRegister : UserControl
    {
        public UserRegister()
        {
            InitializeComponent();
            comboRole.DataSource = Roles.Names;
            comboRole.DisplayMember = "Name";
            comboRole.ValueMember = "Value";

        }

      

        private void Btnentire_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = txtEmail.Text.Trim();
            user.UserName = txtusername.Text.ToLower().Trim();
            user.Password = txtpass.Text.GetHashCode().ToString();
            user.Name = txtName.Text.Trim();
            user.Family = txtFamily.Text;
            user.Role = comboRole.SelectedItem.ToString()== "مدیر" ? Roles.RoleSNames.Admin: Roles.RoleSNames.limited;
            user.UserId = Guid.NewGuid().ToString()+user.UserName.ToString().Substring(5);
            try
            {
                using (irQmDbContext db = new irQmDbContext())
                {
                    if (db.User.Any(u => u.UserName == txtusername.Text))
                    {
                        lblResult.Text = "این نام کاربری قبلا ثبت شده است";
                        lblResult.ForeColor = Color.Red;
                        return;
                    }
                    db.User.Add(user);
                    db.SaveChanges();
                    lblResult.Text = "ثبت انجام شد";
                    lblResult.ForeColor = Color.Green;
                    linklogin.Visible = true;
                }
            }catch(Exception x)
            {
                lblResult.Text = "ایرادی در ثبت به وجود آمده است";
                lblResult.ForeColor = Color.Red;
            }

            

        }

        private void Picexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
