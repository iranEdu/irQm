using irQm.UserControls.Forms;
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
        internal Label lblContactUs;
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
        protected Panel MasterPanel;
        private Label lblTitle;
        private Panel mainPanel;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label12;
        private PictureBox pbSettings;
        private PictureBox pbBackup;
        private PictureBox pbScores;
        private PictureBox pbExamExams;
        private PictureBox pbExam;
        private PictureBox pbQuestionbank;
        private PictureBox pbQuestionReg;
        private PictureBox pbNewLesson;
        private Label label1;

        public MasterForm():base()
        {
            InitializeComponent();
            Init();
        }
        protected virtual void Init()
        {

        }

        private void InitializeComponent()
        {
            this.lblExit = new System.Windows.Forms.Label();
            this.lblContactUs = new System.Windows.Forms.Label();
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
            this.MasterPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbBackup = new System.Windows.Forms.PictureBox();
            this.pbScores = new System.Windows.Forms.PictureBox();
            this.pbExamExams = new System.Windows.Forms.PictureBox();
            this.pbExam = new System.Windows.Forms.PictureBox();
            this.pbQuestionbank = new System.Windows.Forms.PictureBox();
            this.pbQuestionReg = new System.Windows.Forms.PictureBox();
            this.pbNewLesson = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picbook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MasterPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExamExams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionbank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewLesson)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(594, 424);
            this.lblExit.Name = "lblExit";
            this.lblExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExit.Size = new System.Drawing.Size(189, 23);
            this.lblExit.TabIndex = 136;
            this.lblExit.Text = "خروج";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContactUs
            // 
            this.lblContactUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContactUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblContactUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblContactUs.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblContactUs.ForeColor = System.Drawing.Color.White;
            this.lblContactUs.Location = new System.Drawing.Point(598, 391);
            this.lblContactUs.Name = "lblContactUs";
            this.lblContactUs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblContactUs.Size = new System.Drawing.Size(189, 23);
            this.lblContactUs.TabIndex = 135;
            this.lblContactUs.Text = "تماس با ما";
            this.lblContactUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAboutSoftware
            // 
            this.lblAboutSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutSoftware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblAboutSoftware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutSoftware.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAboutSoftware.ForeColor = System.Drawing.Color.White;
            this.lblAboutSoftware.Location = new System.Drawing.Point(595, 356);
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
            this.lblSetting.Location = new System.Drawing.Point(595, 321);
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
            this.lblBackup.Location = new System.Drawing.Point(595, 286);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBackup.Size = new System.Drawing.Size(189, 23);
            this.lblBackup.TabIndex = 132;
            this.lblBackup.Text = "نسخه پشتیبان";
            this.lblBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExamResult
            // 
            this.lblExamResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExamResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblExamResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExamResult.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblExamResult.ForeColor = System.Drawing.Color.White;
            this.lblExamResult.Location = new System.Drawing.Point(595, 251);
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
            this.lblExam.Location = new System.Drawing.Point(595, 216);
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
            this.lblInsertQuestion.Location = new System.Drawing.Point(595, 181);
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
            this.lblNewLesson.Location = new System.Drawing.Point(595, 146);
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
            this.lblMainPage.Location = new System.Drawing.Point(595, 111);
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(593, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 400);
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
            // MasterPanel
            // 
            this.MasterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MasterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MasterPanel.Controls.Add(this.mainPanel);
            this.MasterPanel.Location = new System.Drawing.Point(6, 34);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(583, 431);
            this.MasterPanel.TabIndex = 138;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainPanel.Controls.Add(this.label11);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label12);
            this.mainPanel.Controls.Add(this.pbSettings);
            this.mainPanel.Controls.Add(this.pbBackup);
            this.mainPanel.Controls.Add(this.pbScores);
            this.mainPanel.Controls.Add(this.pbExamExams);
            this.mainPanel.Controls.Add(this.pbExam);
            this.mainPanel.Controls.Add(this.pbQuestionbank);
            this.mainPanel.Controls.Add(this.pbQuestionReg);
            this.mainPanel.Controls.Add(this.pbNewLesson);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(583, 431);
            this.mainPanel.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(48, 354);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(61, 26);
            this.label11.TabIndex = 201;
            this.label11.Text = "تنظیمات";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(186, 354);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(95, 26);
            this.label10.TabIndex = 200;
            this.label10.Text = "نسخه پشتیبان";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(321, 353);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(80, 26);
            this.label9.TabIndex = 199;
            this.label9.Text = "لیست نمرات";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(462, 353);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(82, 26);
            this.label8.TabIndex = 198;
            this.label8.Text = "نتیجه آزمون";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(58, 167);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(46, 26);
            this.label7.TabIndex = 197;
            this.label7.Text = "آزمون";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(180, 167);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 196;
            this.label6.Text = "بانک سوالات";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(326, 167);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 195;
            this.label5.Text = "ثبت سوال";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(463, 168);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(74, 26);
            this.label12.TabIndex = 194;
            this.label12.Text = "درس جدید";
            // 
            // pbSettings
            // 
            this.pbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettings.Image = global::irQm.Properties.Resources.settingpic;
            this.pbSettings.Location = new System.Drawing.Point(27, 236);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(115, 115);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSettings.TabIndex = 193;
            this.pbSettings.TabStop = false;
            // 
            // pbBackup
            // 
            this.pbBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackup.Image = global::irQm.Properties.Resources.backup;
            this.pbBackup.Location = new System.Drawing.Point(164, 236);
            this.pbBackup.Name = "pbBackup";
            this.pbBackup.Size = new System.Drawing.Size(115, 115);
            this.pbBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackup.TabIndex = 192;
            this.pbBackup.TabStop = false;
            // 
            // pbScores
            // 
            this.pbScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbScores.Image = global::irQm.Properties.Resources.marklist;
            this.pbScores.Location = new System.Drawing.Point(302, 236);
            this.pbScores.Name = "pbScores";
            this.pbScores.Size = new System.Drawing.Size(115, 115);
            this.pbScores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScores.TabIndex = 191;
            this.pbScores.TabStop = false;
            // 
            // pbExamExams
            // 
            this.pbExamExams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExamExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExamExams.Image = global::irQm.Properties.Resources.results;
            this.pbExamExams.Location = new System.Drawing.Point(441, 236);
            this.pbExamExams.Name = "pbExamExams";
            this.pbExamExams.Size = new System.Drawing.Size(115, 115);
            this.pbExamExams.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExamExams.TabIndex = 190;
            this.pbExamExams.TabStop = false;
            // 
            // pbExam
            // 
            this.pbExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExam.Image = global::irQm.Properties.Resources.nwexam;
            this.pbExam.Location = new System.Drawing.Point(27, 50);
            this.pbExam.Name = "pbExam";
            this.pbExam.Size = new System.Drawing.Size(115, 115);
            this.pbExam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExam.TabIndex = 189;
            this.pbExam.TabStop = false;
            this.pbExam.Click += new System.EventHandler(this.lblExam_Click);
            // 
            // pbQuestionbank
            // 
            this.pbQuestionbank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbQuestionbank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestionbank.Image = global::irQm.Properties.Resources.questionsbank;
            this.pbQuestionbank.Location = new System.Drawing.Point(164, 50);
            this.pbQuestionbank.Name = "pbQuestionbank";
            this.pbQuestionbank.Size = new System.Drawing.Size(115, 115);
            this.pbQuestionbank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestionbank.TabIndex = 188;
            this.pbQuestionbank.TabStop = false;
            this.pbQuestionbank.Click += new System.EventHandler(this.pbQuestionbank_Click);
            // 
            // pbQuestionReg
            // 
            this.pbQuestionReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbQuestionReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuestionReg.Image = global::irQm.Properties.Resources.addquestion;
            this.pbQuestionReg.Location = new System.Drawing.Point(302, 50);
            this.pbQuestionReg.Name = "pbQuestionReg";
            this.pbQuestionReg.Size = new System.Drawing.Size(115, 115);
            this.pbQuestionReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestionReg.TabIndex = 187;
            this.pbQuestionReg.TabStop = false;
            this.pbQuestionReg.Click += new System.EventHandler(this.lblInsertQuestion_Click);
            // 
            // pbNewLesson
            // 
            this.pbNewLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNewLesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNewLesson.Image = global::irQm.Properties.Resources.New_Lesson0;
            this.pbNewLesson.Location = new System.Drawing.Point(441, 50);
            this.pbNewLesson.Name = "pbNewLesson";
            this.pbNewLesson.Size = new System.Drawing.Size(115, 115);
            this.pbNewLesson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewLesson.TabIndex = 186;
            this.pbNewLesson.TabStop = false;
            this.pbNewLesson.Click += new System.EventHandler(this.lblNewLesson_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblTitle.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(238, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(348, 26);
            this.lblTitle.TabIndex = 139;
            this.lblTitle.Text = "صفحه اصلی";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MasterForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.MasterPanel);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblContactUs);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MasterForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picbook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MasterPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExamExams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionbank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewLesson)).EndInit();
            this.ResumeLayout(false);

        }

        private void lblMainPage_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "صفحه اصلی";
            if (MasterPanel.Controls[0] is FrmMain)
                return;
            mainPanel.Show();
            if (MasterPanel.Controls.Count > 1)
                MasterPanel.Controls.RemoveAt(1);
           


        }

        private void lblNewLesson_Click(object sender, EventArgs e)
        {
           
            if (MasterPanel.Controls[0] is NewLesson)
                return;
            mainPanel.Hide();
            lblTitle.Text = "افزودن درس جدید";

            if (MasterPanel.Controls.Count > 1)
                MasterPanel.Controls.RemoveAt(1);
            var content = new NewLesson();
            content.Dock = DockStyle.Fill;
            MasterPanel.Controls.Add(content);

        }

        private void lblInsertQuestion_Click(object sender, EventArgs e)
        {
           
            if (MasterPanel.Controls[0] is InsertQuestion)
                return;
            mainPanel.Hide();
            lblTitle.Text = "طرح سوال";

            if (MasterPanel.Controls.Count > 1)
                MasterPanel.Controls.RemoveAt(1);
            var content = new InsertQuestion();
            content.Dock = DockStyle.Fill;
            MasterPanel.Controls.Add(content);

        }

        private void lblExam_Click(object sender, EventArgs e)
        {
           
            if (MasterPanel.Controls[0] is Exam)
                return;
            mainPanel.Hide();
            lblTitle.Text = "انجام آزمون";

            if (MasterPanel.Controls.Count > 1)
                MasterPanel.Controls.RemoveAt(1);
            var content = new Exam();
            content.Dock = DockStyle.Fill;
            MasterPanel.Controls.Add(content);
        }

        private void lblExamResult_Click(object sender, EventArgs e)
        {
           
            if (MasterPanel.Controls[0] is Exams)
                return;
            mainPanel.Hide();
            lblTitle.Text = "آزمونها";

            if (MasterPanel.Controls.Count > 1)
                MasterPanel.Controls.RemoveAt(1);
            var content = new Exams();
            content.Dock = DockStyle.Fill;
            MasterPanel.Controls.Add(content);

        }
    

        private void pbQuestionbank_Click(object sender, EventArgs e)
        {
            mainPanel.Hide();
            if (MasterPanel.Controls.Count > 1)
                MasterPanel.Controls.RemoveAt(1);
            lblTitle.Text = "مجموعه پرسش‌ها";

            var content = new Bank();
            content.Dock = DockStyle.Fill;
            MasterPanel.Controls.Add(content);
            content.search();

        }

        private void MasterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
