namespace irQm.UserControls
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.faceBox = new Utilities.FreeSizeRichTextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.CheckBox();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.pbInformation = new System.Windows.Forms.PictureBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.faceBox);
            this.flowLayoutPanel1.Controls.Add(this.lblSubtitle);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(403, 53);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // faceBox
            // 
            this.faceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faceBox.BackColor = System.Drawing.Color.Transparent;
            this.faceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.faceBox.Location = new System.Drawing.Point(3, 3);
            this.faceBox.Name = "faceBox";
            this.faceBox.Size = new System.Drawing.Size(397, 22);
            this.faceBox.TabIndex = 0;
            this.faceBox.Text = "";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Location = new System.Drawing.Point(345, 3);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "label1";
            // 
            // cbSelect
            // 
            this.cbSelect.AutoSize = true;
            this.cbSelect.Location = new System.Drawing.Point(386, 3);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(15, 14);
            this.cbSelect.TabIndex = 3;
            this.cbSelect.UseVisualStyleBackColor = true;
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
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Location = new System.Drawing.Point(365, 28);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(35, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "label1";
            // 
            // UCQuestionListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbInformation);
            this.Controls.Add(this.pbRemove);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCQuestionListItem";
            this.Size = new System.Drawing.Size(404, 79);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Utilities.FreeSizeRichTextBox faceBox;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.CheckBox cbSelect;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.PictureBox pbInformation;
        private System.Windows.Forms.Label lblSubtitle;
    }
}
