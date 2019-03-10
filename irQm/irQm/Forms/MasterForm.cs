using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.Forms
{
    public class MasterForm:ExtendedForm
    {
        internal Label lblExit;
        internal Label lblUserEdit;
        internal Label lblAboutSoftware;
        internal Label lblSetting;
        internal Label lblBackup;
        internal Label lblExamResult;
        internal Label lblExam;
        internal Label lblInsertQuestion;
        internal Label lblNewLesson;
        internal Label lblMainPage;
        private Label label3;
        private PictureBox Picbook;
        private Label label2;
        private PictureBox pictureBox1;
        internal Label lblnewuser;
        internal Label lblchangpass;
        private Label label1;

        public MasterForm():base()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.lblExit = new System.Windows.Forms.Label();
            this.lblUserEdit = new System.Windows.Forms.Label();
            this.lblAboutSoftware = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            this.lblExamResult = new System.Windows.Forms.Label();
            this.lblExam = new System.Windows.Forms.Label();
            this.lblInsertQuestion = new System.Windows.Forms.Label();
            this.lblNewLesson = new System.Windows.Forms.Label();
            this.lblMainPage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Picbook = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnewuser = new System.Windows.Forms.Label();
            this.lblchangpass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(594, 433);
            this.lblExit.Name = "lblExit";
            this.lblExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExit.Size = new System.Drawing.Size(189, 23);
            this.lblExit.TabIndex = 136;
            this.lblExit.Text = "خروج";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblUserEdit
            // 
            this.lblUserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblUserEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserEdit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserEdit.ForeColor = System.Drawing.Color.White;
            this.lblUserEdit.Location = new System.Drawing.Point(594, 318);
            this.lblUserEdit.Name = "lblUserEdit";
            this.lblUserEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserEdit.Size = new System.Drawing.Size(189, 23);
            this.lblUserEdit.TabIndex = 135;
            this.lblUserEdit.Text = "وبرایش اطلاعات کاربری";
            this.lblUserEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserEdit.Click += new System.EventHandler(this.lblUserEdit_Click);
            // 
            // lblAboutSoftware
            // 
            this.lblAboutSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblAboutSoftware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutSoftware.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAboutSoftware.ForeColor = System.Drawing.Color.White;
            this.lblAboutSoftware.Location = new System.Drawing.Point(594, 403);
            this.lblAboutSoftware.Name = "lblAboutSoftware";
            this.lblAboutSoftware.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAboutSoftware.Size = new System.Drawing.Size(189, 23);
            this.lblAboutSoftware.TabIndex = 134;
            this.lblAboutSoftware.Text = "درباره نرم افزار";
            this.lblAboutSoftware.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetting
            // 
            this.lblSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSetting.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSetting.ForeColor = System.Drawing.Color.White;
            this.lblSetting.Location = new System.Drawing.Point(593, 378);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSetting.Size = new System.Drawing.Size(189, 23);
            this.lblSetting.TabIndex = 133;
            this.lblSetting.Text = "تنظیمات";
            this.lblSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBackup
            // 
            this.lblBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackup.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBackup.ForeColor = System.Drawing.Color.White;
            this.lblBackup.Location = new System.Drawing.Point(594, 284);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBackup.Size = new System.Drawing.Size(189, 23);
            this.lblBackup.TabIndex = 132;
            this.lblBackup.Text = "نسخه پشتیبان";
            this.lblBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBackup.Click += new System.EventHandler(this.lblBackup_Click);
            // 
            // lblExamResult
            // 
            this.lblExamResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExamResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblExamResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExamResult.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExamResult.ForeColor = System.Drawing.Color.White;
            this.lblExamResult.Location = new System.Drawing.Point(594, 254);
            this.lblExamResult.Name = "lblExamResult";
            this.lblExamResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExamResult.Size = new System.Drawing.Size(189, 23);
            this.lblExamResult.TabIndex = 131;
            this.lblExamResult.Text = "نتیجه آزمون";
            this.lblExamResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExamResult.Click += new System.EventHandler(this.lblExamResult_Click);
            // 
            // lblExam
            // 
            this.lblExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExam.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExam.ForeColor = System.Drawing.Color.White;
            this.lblExam.Location = new System.Drawing.Point(594, 224);
            this.lblExam.Name = "lblExam";
            this.lblExam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExam.Size = new System.Drawing.Size(189, 23);
            this.lblExam.TabIndex = 130;
            this.lblExam.Text = "آزمون";
            this.lblExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExam.Click += new System.EventHandler(this.lblExam_Click);
            // 
            // lblInsertQuestion
            // 
            this.lblInsertQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInsertQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblInsertQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInsertQuestion.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInsertQuestion.ForeColor = System.Drawing.Color.White;
            this.lblInsertQuestion.Location = new System.Drawing.Point(594, 194);
            this.lblInsertQuestion.Name = "lblInsertQuestion";
            this.lblInsertQuestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInsertQuestion.Size = new System.Drawing.Size(189, 23);
            this.lblInsertQuestion.TabIndex = 129;
            this.lblInsertQuestion.Text = "ثبت سوال";
            this.lblInsertQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInsertQuestion.Click += new System.EventHandler(this.lblInsertQuestion_Click);
            // 
            // lblNewLesson
            // 
            this.lblNewLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblNewLesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNewLesson.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNewLesson.ForeColor = System.Drawing.Color.White;
            this.lblNewLesson.Location = new System.Drawing.Point(594, 164);
            this.lblNewLesson.Name = "lblNewLesson";
            this.lblNewLesson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNewLesson.Size = new System.Drawing.Size(189, 23);
            this.lblNewLesson.TabIndex = 128;
            this.lblNewLesson.Text = "درس جدید";
            this.lblNewLesson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewLesson.Click += new System.EventHandler(this.lblNewLesson_Click);
            // 
            // lblMainPage
            // 
            this.lblMainPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMainPage.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblMainPage.ForeColor = System.Drawing.Color.White;
            this.lblMainPage.Location = new System.Drawing.Point(594, 103);
            this.lblMainPage.Name = "lblMainPage";
            this.lblMainPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMainPage.Size = new System.Drawing.Size(189, 23);
            this.lblMainPage.TabIndex = 127;
            this.lblMainPage.Text = "صفحه اصلی";
            this.lblMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMainPage.Click += new System.EventHandler(this.lblMainPage_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(638, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 33);
            this.label3.TabIndex = 126;
            this.label3.Text = "آزمون یار معلم";
            // 
            // Picbook
            // 
            this.Picbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Picbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.Picbook.Image = global::irQm.Properties.Resources.bookpic;
            this.Picbook.Location = new System.Drawing.Point(601, 4);
            this.Picbook.Name = "Picbook";
            this.Picbook.Size = new System.Drawing.Size(172, 69);
            this.Picbook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picbook.TabIndex = 125;
            this.Picbook.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(593, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 366);
            this.label2.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(592, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 98);
            this.label1.TabIndex = 123;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::irQm.Properties.Resources.topribon;
            this.pictureBox1.Location = new System.Drawing.Point(204, -36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // lblnewuser
            // 
            this.lblnewuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnewuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblnewuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblnewuser.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblnewuser.ForeColor = System.Drawing.Color.White;
            this.lblnewuser.Location = new System.Drawing.Point(594, 134);
            this.lblnewuser.Name = "lblnewuser";
            this.lblnewuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblnewuser.Size = new System.Drawing.Size(189, 23);
            this.lblnewuser.TabIndex = 138;
            this.lblnewuser.Text = " کاربر جدید";
            this.lblnewuser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblchangpass
            // 
            this.lblchangpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblchangpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblchangpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblchangpass.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblchangpass.ForeColor = System.Drawing.Color.White;
            this.lblchangpass.Location = new System.Drawing.Point(593, 349);
            this.lblchangpass.Name = "lblchangpass";
            this.lblchangpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblchangpass.Size = new System.Drawing.Size(189, 23);
            this.lblchangpass.TabIndex = 139;
            this.lblchangpass.Text = "تغییر کلمه عبور";
            this.lblchangpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MasterForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblchangpass);
            this.Controls.Add(this.lblnewuser);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblUserEdit);
            this.Controls.Add(this.lblAboutSoftware);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.lblExamResult);
            this.Controls.Add(this.lblExam);
            this.Controls.Add(this.lblInsertQuestion);
            this.Controls.Add(this.lblNewLesson);
            this.Controls.Add(this.lblMainPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Picbook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MasterForm";
            ((System.ComponentModel.ISupportInitialize)(this.Picbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void lblMainPage_Click(object sender, EventArgs e)
        {
            if (this is FrmMain)
                return;
            Form mf = new FrmMain();

            mf.Show();
            this.Close();

        }

        private void lblNewLesson_Click(object sender, EventArgs e)
        {
            if (this is Frmnewlesson)
                return;
            Form nl = new Frmnewlesson();
            nl.Show();
            this.Close();

        }

        private void lblInsertQuestion_Click(object sender, EventArgs e)
        {
            if (this is FrmInsertQuestion)
                return;
            Form iq = new FrmInsertQuestion();
            iq.Show();
            this.Close();

        }

        private void lblExam_Click(object sender, EventArgs e)
        {
            if (this is FrmExam)
                return;
            Form fe = new FrmExam();
            fe.Show();
            this.Close();
        }

        private void lblExamResult_Click(object sender, EventArgs e)
        {
            if (this is FrmExamResult)
                return;
            Form fer = new FrmExamResult();
            fer.Show();
            this.Close();

        }

        private void lblUserEdit_Click(object sender, EventArgs e)
        {
            if (this is UserEditForm)
                return;
            UserEditForm userEditForm = new UserEditForm();
            userEditForm.Show();
            this.Close();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBackup_Click(object sender, EventArgs e)
        {
            BackupAndRestoreForm backup = new BackupAndRestoreForm();
            backup.Show();
        }
    }
}
