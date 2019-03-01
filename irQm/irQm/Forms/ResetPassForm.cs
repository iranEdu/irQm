using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendGrid;
using System.Net;
using System.Configuration;
using System.Diagnostics;
using System.Net.Mail;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Collections.Specialized;


namespace irQm.Forms
{
    public partial class ResetPassForm : MasterForm
    {
        public ResetPassForm()
        {
            InitializeComponent();
           
        }
        public static int randomnumber;

        private void SendWebMailMessage()
        {
            try
            {



                var fromAddress = new MailAddress("s.taghilonia@gmail.com", "From:");
                var toAddress = new MailAddress(txtemail.Text, "To:");
                const string fromPassword = "*******";
                Random rnd = new Random();
                int randomcode = rnd.Next(1000, 9999);

                string subject = "بازیابی رمز عبور";
                string body = "کد احراز هویت:" + randomcode;
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
                }
            }
            catch (Exception)
            {

                MessageBox.Show("آدرس ایمیل را اشتباه وارد کرده‌اید","خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

       
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SendWebMailMessage();
                              
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmailcode.Text==Convert.ToString(irQm.Forms.ResetPassForm.randomnumber))
            {
                panelresetpass.Visible = true;
               
               
                
            }
        }
    }
}
