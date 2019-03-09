using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using irQm.BaseCodes;
using irQm.BaseCodes.Utilities;

namespace irQm.Forms
{
    public partial class UserEditForm : MasterForm
    {
        public UserEditForm()
        {
            InitializeComponent();
            comboRole.DataSource = Roles.Names;
            comboRole.DisplayMember = "Name";
            comboRole.ValueMember = "Value";
            using (irQmDbContext db = new irQmDbContext())
            {
                var user = db.User.First(u => u.UserName == Globals.CurrentUser.UserName);
                txtusername.Text = user.UserName;
                txtEmail.Text = user.Email;
                txtName.Text = user.Name;
                txtFamily.Text = user.Family;
                comboRole.SelectedValue = user.Role;
            }
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

        private void btnSelectUser_Click(object sender, EventArgs e)
        { 
            List<string> users;
            using (irQmDbContext db = new irQmDbContext())
            {
                users = db.User.Select(u=>u.UserName).ToList();
            }
            FrmItems frm = new FrmItems(users, new string[] { });
            
            frm.ShowDialog();
            if (frm.SelectedList.Count > 0)
            {
                txtusername.Text = frm.SelectedList[0];
                using (irQmDbContext db = new irQmDbContext())
                {
                    var user = db.User.First(u => u.UserName== frm.SelectedList[0]);
                    txtEmail.Text = user.Email;
                    txtName.Text = user.Name;
                    txtFamily.Text = user.Family;
                    comboRole.SelectedValue =(Roles.RoleSNames) user.Role;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (irQmDbContext db = new irQmDbContext())
                {
                    var user = db.User.First(u => u.UserName == txtusername.Text);
                    user.Email = txtEmail.Text;
                    user.Name = txtName.Text;
                    user.Family = txtFamily.Text;
                    user.Role = (Roles.RoleSNames)comboRole.SelectedValue;
                    db.SaveChanges();
                    lblMessage.Text = "عملیات تغییر اطلاعات با موفقیت انجام شد";
                }
            }
            catch { lblMessage.Text = "مشکلی در تغییر اطلاعات به وجود آمده است"; }
        }
    }
}
    

