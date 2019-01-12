using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace irQm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var db = new irQm.BaseCodes.irQmDbContext())
            {
                db.Database.EnsureCreated();
            }

        }

      

        private void Btnentire_Click(object sender, EventArgs e)
        {
            FrmMain Fm = new FrmMain();
            Fm.ShowDialog();
        }

        private void Picexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Picimg_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //نام فرستنده
                mail.From = new MailAddress("no-replay@nobody.com");
                //آدرس گیرنده یا گیرندگان
                mail.To.Add("younes_ebrahimi_1391@yahoo.com");
                //عنوان ایمیل
                mail.Subject = "Test Mail";
                //بدنه ایمیل
                mail.Body = "This is for testing SMTP mail from GMAIL";
                //مشخص کرن پورت 
                SmtpServer.Port = 587;
                //username : به جای این کلمه نام کاربری ایمیل خود را قرار دهید
                //password : به جای این کلمه رمز عبور ایمیل خود را قرار دهید
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
