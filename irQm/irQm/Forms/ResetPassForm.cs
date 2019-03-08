using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using irQm.BaseCodes;
using System.Collections.Generic;


namespace irQm.Forms
{
    public partial class ResetPassForm : MasterForm
    {
        public ResetPassForm()
        {
            InitializeComponent();
           
        }
        public static int randomnumber;
        public static string mail;
        private User user;

        private void SendWebMailMessage()
        {
                     
            try
            {
                                         
                var fromAddress = new MailAddress("porsan.app.ir@gmail.com", "پرسان");
                var toAddress = new MailAddress(user.Email, user.Name+" "+user.Family);
                const string fromPassword = "@)19irQmmvshk";
                Random rnd = new Random();
                int randomcode = rnd.Next(1000, 9999);

                string subject = "بازیابی رمز عبور";
                string body = "کد احراز هویت:" + randomcode;
                mail = txtUsername.Text;
                randomnumber = randomcode;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

                };
                smtp.SendCompleted += Smtp_SendCompleted;
                var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                };
                {
                    lblMessage.ForeColor = Color.LimeGreen;
                    lblMessage.Text = "در حال انجام";
                    smtp.SendAsync(message,"");

                    
                    
                    tableLayoutPanel2.Visible = true; 
                   
                    
                }
            }
            catch (Exception)
            {
                
                
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "اتصال به اینترنت را بررسی نمایید";
                Btnsendmail.Visible = true;
            }

        }

        private void Smtp_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
           if(e.Error !=null)
            {
                lblMessage.ForeColor = Color.Red;
                
                lblMessage.Text = "خطایی پیش آمده است";
            }
           else if(!e.Cancelled)
            {
                lblMessage.ForeColor = Color.LimeGreen;

                lblMessage.Text = "کد احراز هویت به آدرس ایمیل ارسال شد ";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (txtmailcode.Text == Convert.ToString(randomnumber))
            {
                panelresetpass.Visible = true;
                lblMessage.Text = "";

            }
        }

        

        private void Btnsendmail_Click_1(object sender, EventArgs e)
        {
            using (irQmDbContext db = new irQmDbContext())
            {
                user = db.User.FirstOrDefault(u => u.UserName == txtUsername.Text.Trim());
                if (user == null)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "این نام کاربری وجود ندارد";
                   
                    return;
                }
                if(string.IsNullOrWhiteSpace(user.Email))
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "برای این نام کاربری هیچ ایمیلی وجود ندارد";
                    
                    return;
                }
            }
                SendWebMailMessage();

        }

        private void btncheckcode_Click(object sender, EventArgs e)
        {

        }

        private void btnsavepass_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text == txtconfirmpass.Text)
            {
                ChangePassword(txtnewpass.Text);
            }
            else
                MessageBox.Show(" رمز جدید با تکرار رمز مغابرت دارد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            /*var user = new User { Email = mail, Password = txtnewpass.Text };
            irQmDbContext db = new irQmDbContext();
            db.User.Attach(user).Property(x => x.Password).IsModified = true;
            db.SaveChanges();*/
                                             
            
        }
        private void ChangePassword(string password)
        {
            using (irQmDbContext db = new irQmDbContext())
            {
                var usr = db.User.First(u=>u.UserId==user.UserId);
                usr.Password = password.GetHashCode().ToString();
                db.SaveChanges();
            }
            lblMessage.ForeColor = Color.LimeGreen;
            lblMessage.Text = "عملیات تغییر رمز با موفقیت انجام شد";
        }
    }
}
