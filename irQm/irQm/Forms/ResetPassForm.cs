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


        private void SendWebMailMessage()
        {
                     
            try
            {
                                         
                var fromAddress = new MailAddress("s.taghilonia@gmail.com", "From:");
                var toAddress = new MailAddress(txtemail.Text, "To:");
                const string fromPassword = "********";
                Random rnd = new Random();
                int randomcode = rnd.Next(1000, 9999);

                string subject = "بازیابی رمز عبور";
                string body = "کد احراز هویت:" + randomcode;
                mail = txtemail.Text;
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
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    
                    MessageBox.Show("کد احراز هویت به آدرس ایمیل ارسال شد ", "پیغام", MessageBoxButtons.OK);
                    
                    tableLayoutPanel2.Visible = true; 
                   
                    
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("اتصال به اینترنت و آدرس ایمیل وارد شده را بررسی نمایید. ","خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btnsendmail.Visible = true;
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


            }
        }

        

        private void Btnsendmail_Click_1(object sender, EventArgs e)
        {
          
             SendWebMailMessage();

        }

        private void btncheckcode_Click(object sender, EventArgs e)
        {

        }

        private void btnsavepass_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text == txtconfirmpass.Text)
            {
                ChangePassword(mail, txtnewpass.Text);
            }
            else
                MessageBox.Show(" رمز جدید با تکرار رمز مغابرت دارد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            /*var user = new User { Email = mail, Password = txtnewpass.Text };
            irQmDbContext db = new irQmDbContext();
            db.User.Attach(user).Property(x => x.Password).IsModified = true;
            db.SaveChanges();*/
                                             
            
        }
        public void ChangePassword(string email, string password)
        {
            irQmDbContext db = new irQmDbContext();
            var user = db.User.FirstOrDefault(u => u.Email == mail);
            user.Password = txtnewpass.Text;
            db.SaveChanges();
        }
    }
}
