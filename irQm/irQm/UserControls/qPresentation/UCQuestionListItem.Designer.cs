namespace irQm.UserControls.qPresentation
{
    partial class UCQuestionListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.pbInformation = new System.Windows.Forms.PictureBox();
            this.faceBox = new irQm.UserControls.Utilities.FreeSizeRichTextBox();
            this.showQuestion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(395, 20);
            this.lblSubtitle.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(100, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "label1";
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Location = new System.Drawing.Point(395, 3);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumber.Size = new System.Drawing.Size(80, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "label1";
            // 
            // cbSelect
            // 
            this.cbSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelect.AutoSize = true;
            this.cbSelect.Location = new System.Drawing.Point(480, 3);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(15, 14);
            this.cbSelect.TabIndex = 3;
            this.cbSelect.UseVisualStyleBackColor = true;
            this.cbSelect.CheckedChanged += new System.EventHandler(this.cbSelect_CheckedChanged);
            // 
            // pbRemove
            // 
            this.pbRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemove.Image = global::irQm.Properties.Resources.removemark;
            this.pbRemove.Location = new System.Drawing.Point(3, 1);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(20, 22);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemove.TabIndex = 121;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            // 
            // pbInformation
            // 
            this.pbInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInformation.Image = global::irQm.Properties.Resources.baseline_more_black_18dp;
            this.pbInformation.Location = new System.Drawing.Point(29, 1);
            this.pbInformation.Name = "pbInformation";
            this.pbInformation.Size = new System.Drawing.Size(29, 22);
            this.pbInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInformation.TabIndex = 122;
            this.pbInformation.TabStop = false;
            // 
            // faceBox
            // 
            this.faceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.faceBox.BackColor = System.Drawing.Color.Transparent;
            this.faceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.faceBox.Location = new System.Drawing.Point(15, 47);
            this.faceBox.Name = "faceBox";
            this.faceBox.ReadOnly = true;
            this.faceBox.Size = new System.Drawing.Size(470, 18);
            this.faceBox.TabIndex = 0;
            this.faceBox.Text = "";
            // 
            // showQuestion
            // 
            this.showQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showQuestion.Location = new System.Drawing.Point(314, 0);
            this.showQuestion.Name = "showQuestion";
            this.showQuestion.Size = new System.Drawing.Size(75, 23);
            this.showQuestion.TabIndex = 123;
            this.showQuestion.Text = "نمایش پرسش";
            this.showQuestion.UseVisualStyleBackColor = true;
            this.showQuestion.Click += new System.EventHandler(this.showQuestion_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(219, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 123;
            this.button1.Text = "ویرایش پرسش";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UCQuestionListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showQuestion);
            this.Controls.Add(this.faceBox);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pbInformation);
            this.Controls.Add(this.pbRemove);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.lblNumber);
            this.Name = "UCQuestionListItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(498, 68);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Utilities.FreeSizeRichTextBox faceBox;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.CheckBox cbSelect;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.PictureBox pbInformation;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button showQuestion;
        private System.Windows.Forms.Button button1;
    }
}
