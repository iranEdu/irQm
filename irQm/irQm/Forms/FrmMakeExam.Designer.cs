namespace irQm.Forms
{
    partial class FrmMakeExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboHour = new System.Windows.Forms.ComboBox();
            this.comboMinute = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboStartHour = new System.Windows.Forms.ComboBox();
            this.comboStartMinute = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtEPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalMark = new System.Windows.Forms.Label();
            this.createExamFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpSelectedQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboHour);
            this.panel1.Controls.Add(this.comboMinute);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboStartHour);
            this.panel1.Controls.Add(this.comboStartMinute);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.txtEPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTotalMark);
            this.panel1.Controls.Add(this.createExamFile);
            this.panel1.Controls.Add(this.faDatePicker1);
            this.panel1.Location = new System.Drawing.Point(221, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(318, 261);
            this.panel1.TabIndex = 148;
            // 
            // comboHour
            // 
            this.comboHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHour.FormattingEnabled = true;
            this.comboHour.Location = new System.Drawing.Point(134, 112);
            this.comboHour.Name = "comboHour";
            this.comboHour.Size = new System.Drawing.Size(43, 21);
            this.comboHour.TabIndex = 31;
            // 
            // comboMinute
            // 
            this.comboMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMinute.FormattingEnabled = true;
            this.comboMinute.Location = new System.Drawing.Point(194, 112);
            this.comboMinute.Name = "comboMinute";
            this.comboMinute.Size = new System.Drawing.Size(43, 21);
            this.comboMinute.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "مدت آزمون:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(178, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(177, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = ":";
            // 
            // comboStartHour
            // 
            this.comboStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStartHour.FormattingEnabled = true;
            this.comboStartHour.Location = new System.Drawing.Point(134, 85);
            this.comboStartHour.Name = "comboStartHour";
            this.comboStartHour.Size = new System.Drawing.Size(43, 21);
            this.comboStartHour.TabIndex = 26;
            // 
            // comboStartMinute
            // 
            this.comboStartMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStartMinute.FormattingEnabled = true;
            this.comboStartMinute.Location = new System.Drawing.Point(193, 85);
            this.comboStartMinute.Name = "comboStartMinute";
            this.comboStartMinute.Size = new System.Drawing.Size(43, 21);
            this.comboStartMinute.TabIndex = 25;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Location = new System.Drawing.Point(19, 229);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(256, 23);
            this.lblMessage.TabIndex = 24;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEPass
            // 
            this.txtEPass.Location = new System.Drawing.Point(142, 59);
            this.txtEPass.Name = "txtEPass";
            this.txtEPass.PasswordChar = '*';
            this.txtEPass.Size = new System.Drawing.Size(100, 20);
            this.txtEPass.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "زمان آزمون:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "رمز اریابی:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "رمز اریابی:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(52, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "نام آزمون:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 33);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "رمز کاربر:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "نمره کل:";
            // 
            // lblTotalMark
            // 
            this.lblTotalMark.Location = new System.Drawing.Point(145, 138);
            this.lblTotalMark.Name = "lblTotalMark";
            this.lblTotalMark.Size = new System.Drawing.Size(100, 19);
            this.lblTotalMark.TabIndex = 13;
            this.lblTotalMark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createExamFile
            // 
            this.createExamFile.Location = new System.Drawing.Point(181, 160);
            this.createExamFile.Name = "createExamFile";
            this.createExamFile.Size = new System.Drawing.Size(122, 23);
            this.createExamFile.TabIndex = 12;
            this.createExamFile.Text = "ایجاد فایل آزمون";
            this.createExamFile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.flpSelectedQuestions);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 261);
            this.panel2.TabIndex = 149;
            // 
            // flpSelectedQuestions
            // 
            this.flpSelectedQuestions.AllowDrop = true;
            this.flpSelectedQuestions.AutoScroll = true;
            this.flpSelectedQuestions.AutoSize = true;
            this.flpSelectedQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSelectedQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSelectedQuestions.Location = new System.Drawing.Point(0, 0);
            this.flpSelectedQuestions.Name = "flpSelectedQuestions";
            this.flpSelectedQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.flpSelectedQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpSelectedQuestions.Size = new System.Drawing.Size(215, 261);
            this.flpSelectedQuestions.TabIndex = 148;
            this.flpSelectedQuestions.WrapContents = false;
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(7, 85);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(120, 20);
            this.faDatePicker1.TabIndex = 23;
            // 
            // FrmMakeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMakeExam";
            this.ShowInTaskbar = false;
            this.Text = "FrmMakeExam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMakeExam_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMakeExam_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboHour;
        private System.Windows.Forms.ComboBox comboMinute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboStartHour;
        private System.Windows.Forms.ComboBox comboStartMinute;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtEPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalMark;
        private System.Windows.Forms.Button createExamFile;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpSelectedQuestions;
    }
}