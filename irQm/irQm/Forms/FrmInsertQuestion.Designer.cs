

using irQm.BaseCodes;
using irQm.UserControls.Utilities;

namespace irQm.Forms
{
    partial class FrmInsertQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsertQuestion));
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboLesson = new irQm.UserControls.Utilities.LessonsComboBox();
            this.comboQuestionType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucLongAnswer2 = new irQm.UCLongAnswer();
            this.ucTrueFalseAnswer1 = new irQm.UCTrueFalseAnswer();
            this.ucShortAnswer1 = new irQm.UCShortAnswer();
            this.ucPracticalAnswer1 = new irQm.UCPracticalAnswer();
            this.ucMultiOption1 = new irQm.UCMultiOption();
            this.ucLongAnswer1 = new irQm.UCLongAnswer();
            this.ucPuzzleAnswer1 = new irQm.UCPuzzleAnswer();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tagsBox1 = new irQm.TagsBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rbFace = new irQm.BaseCodes.CustomizedRichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ucPuzzleAnswer2 = new irQm.UCPuzzleAnswer();
            this.ucPuzzleAnswer3 = new irQm.UCPuzzleAnswer();
            this.ucPuzzlePairs1 = new irQm.UserControls.UCPuzzlePairs();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(351, 4);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(233, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "ورود  >  صفحه اصلی  >  ثبت سوال";
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(514, 40);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(67, 35);
            this.label8.TabIndex = 107;
            this.label8.Text = "نام درس:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(238, 40);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(67, 35);
            this.label9.TabIndex = 108;
            this.label9.Text = "نوع سوال:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboLesson
            // 
            this.comboLesson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLesson.Location = new System.Drawing.Point(372, 47);
            this.comboLesson.Name = "comboLesson";
            this.comboLesson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboLesson.Size = new System.Drawing.Size(142, 28);
            this.comboLesson.TabIndex = 109;
            // 
            // comboQuestionType
            // 
            this.comboQuestionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuestionType.FormattingEnabled = true;
            this.comboQuestionType.Location = new System.Drawing.Point(114, 47);
            this.comboQuestionType.Name = "comboQuestionType";
            this.comboQuestionType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboQuestionType.Size = new System.Drawing.Size(121, 21);
            this.comboQuestionType.TabIndex = 110;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ucLongAnswer2);
            this.panel1.Controls.Add(this.ucTrueFalseAnswer1);
            this.panel1.Controls.Add(this.ucShortAnswer1);
            this.panel1.Controls.Add(this.ucPracticalAnswer1);
            this.panel1.Controls.Add(this.ucMultiOption1);
            this.panel1.Controls.Add(this.ucLongAnswer1);
            this.panel1.Controls.Add(this.ucPuzzleAnswer1);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tagsBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.rbFace);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 414);
            this.panel1.TabIndex = 111;
            // 
            // ucLongAnswer2
            // 
            this.ucLongAnswer2.Answer = "";
            this.ucLongAnswer2.Location = new System.Drawing.Point(10, 179);
            this.ucLongAnswer2.Name = "ucLongAnswer2";
            this.ucLongAnswer2.Size = new System.Drawing.Size(545, 181);
            this.ucLongAnswer2.TabIndex = 144;
            // 
            // ucTrueFalseAnswer1
            // 
            this.ucTrueFalseAnswer1.isFalse = false;
            this.ucTrueFalseAnswer1.isTrue = false;
            this.ucTrueFalseAnswer1.Location = new System.Drawing.Point(26, 195);
            this.ucTrueFalseAnswer1.Name = "ucTrueFalseAnswer1";
            this.ucTrueFalseAnswer1.Size = new System.Drawing.Size(531, 50);
            this.ucTrueFalseAnswer1.TabIndex = 143;
            // 
            // ucShortAnswer1
            // 
            this.ucShortAnswer1.Location = new System.Drawing.Point(10, 175);
            this.ucShortAnswer1.Name = "ucShortAnswer1";
            this.ucShortAnswer1.Size = new System.Drawing.Size(530, 173);
            this.ucShortAnswer1.TabIndex = 142;
            // 
            // ucPracticalAnswer1
            // 
            this.ucPracticalAnswer1.Location = new System.Drawing.Point(10, 179);
            this.ucPracticalAnswer1.Name = "ucPracticalAnswer1";
            this.ucPracticalAnswer1.Size = new System.Drawing.Size(543, 188);
            this.ucPracticalAnswer1.TabIndex = 141;
            // 
            // ucMultiOption1
            // 
            this.ucMultiOption1.Location = new System.Drawing.Point(10, 179);
            this.ucMultiOption1.Name = "ucMultiOption1";
            this.ucMultiOption1.Size = new System.Drawing.Size(542, 199);
            this.ucMultiOption1.TabIndex = 140;
            // 
            // ucLongAnswer1
            // 
            this.ucLongAnswer1.Answer = "";
            this.ucLongAnswer1.Location = new System.Drawing.Point(10, 179);
            this.ucLongAnswer1.Name = "ucLongAnswer1";
            this.ucLongAnswer1.Size = new System.Drawing.Size(542, 173);
            this.ucLongAnswer1.TabIndex = 139;
            // 
            // ucPuzzleAnswer1
            // 
            this.ucPuzzleAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPuzzleAnswer1.Location = new System.Drawing.Point(10, 179);
            this.ucPuzzleAnswer1.Name = "ucPuzzleAnswer1";
            this.ucPuzzleAnswer1.Size = new System.Drawing.Size(546, 173);
            this.ucPuzzleAnswer1.StringPairs = ((System.Collections.Generic.List<irQm.BaseCodes.StringPair>)(resources.GetObject("ucPuzzleAnswer1.StringPairs")));
            this.ucPuzzleAnswer1.TabIndex = 138;
            this.ucPuzzleAnswer1.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnNew.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(24, 371);
            this.btnNew.Name = "btnNew";
            this.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 117;
            this.btnNew.Text = "+ جدید";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnRegister.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(115, 373);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegister.Size = new System.Drawing.Size(85, 39);
            this.btnRegister.TabIndex = 116;
            this.btnRegister.Text = " ثبت";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(206, 385);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(350, 25);
            this.lblMessage.TabIndex = 120;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(483, 125);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 119;
            this.label6.Text = "برچسب ها:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tagsBox1
            // 
            this.tagsBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagsBox1.Location = new System.Drawing.Point(7, 153);
            this.tagsBox1.Name = "tagsBox1";
            this.tagsBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tagsBox1.Size = new System.Drawing.Size(545, 20);
            this.tagsBox1.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(512, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(46, 25);
            this.label7.TabIndex = 114;
            this.label7.Text = "سوال:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 112;
            this.pictureBox2.TabStop = false;
            // 
            // rbFace
            // 
            this.rbFace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFace.Location = new System.Drawing.Point(8, 30);
            this.rbFace.Name = "rbFace";
            this.rbFace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbFace.Size = new System.Drawing.Size(544, 90);
            this.rbFace.TabIndex = 111;
            this.rbFace.Text = "";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(559, 35);
            this.label5.TabIndex = 113;
            this.label5.Text = "+ ثبت سوال چند گزینه‌ای";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucPuzzleAnswer2
            // 
            this.ucPuzzleAnswer2.Location = new System.Drawing.Point(0, 0);
            this.ucPuzzleAnswer2.Name = "ucPuzzleAnswer2";
            this.ucPuzzleAnswer2.Size = new System.Drawing.Size(529, 179);
            this.ucPuzzleAnswer2.StringPairs = ((System.Collections.Generic.List<irQm.BaseCodes.StringPair>)(resources.GetObject("ucPuzzleAnswer2.StringPairs")));
            this.ucPuzzleAnswer2.TabIndex = 0;
            // 
            // ucPuzzleAnswer3
            // 
            this.ucPuzzleAnswer3.Location = new System.Drawing.Point(0, 0);
            this.ucPuzzleAnswer3.Name = "ucPuzzleAnswer3";
            this.ucPuzzleAnswer3.Size = new System.Drawing.Size(529, 179);
            this.ucPuzzleAnswer3.StringPairs = ((System.Collections.Generic.List<irQm.BaseCodes.StringPair>)(resources.GetObject("ucPuzzleAnswer3.StringPairs")));
            this.ucPuzzleAnswer3.TabIndex = 0;
            // 
            // ucPuzzlePairs1
            // 
            this.ucPuzzlePairs1.Location = new System.Drawing.Point(0, 0);
            this.ucPuzzlePairs1.Name = "ucPuzzlePairs1";
            this.ucPuzzlePairs1.Pairs = ((System.Collections.Generic.List<irQm.BaseCodes.StringPair>)(resources.GetObject("ucPuzzlePairs1.Pairs")));
            this.ucPuzzlePairs1.Size = new System.Drawing.Size(487, 169);
            this.ucPuzzlePairs1.TabIndex = 0;
            // 
            // FrmInsertQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboQuestionType);
            this.Controls.Add(this.comboLesson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "FrmInsertQuestion";
            this.Text = "FrmInsertQuestion";
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.comboLesson, 0);
            this.Controls.SetChildIndex(this.comboQuestionType, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        private LessonsComboBox comboLesson;
        private System.Windows.Forms.ComboBox comboQuestionType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomizedRichTextBox rbFace;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRegister;
        internal System.Windows.Forms.Label label6;
        private TagsBox tagsBox1;
        private System.Windows.Forms.Label lblMessage;
        private UCPuzzleAnswer ucPuzzleAnswer1;
        private UCTrueFalseAnswer ucTrueFalseAnswer1;
        private UCShortAnswer ucShortAnswer1;
        private UCPracticalAnswer ucPracticalAnswer1;
        private UCMultiOption ucMultiOption1;
        private UCLongAnswer ucLongAnswer1;
        private UCPuzzleAnswer ucPuzzleAnswer2;
        private UCPuzzleAnswer ucPuzzleAnswer3;
        private UserControls.UCPuzzlePairs ucPuzzlePairs1;
        private UCLongAnswer ucLongAnswer2;
    }
}