using irQm.BaseCodes;
namespace irQm.UserControls
{
    partial class UCOption
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
            this.rtbOption = new CustomizedRichTextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.cbIsTrue = new System.Windows.Forms.CheckBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbOption
            // 
            this.rtbOption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOption.Location = new System.Drawing.Point(87, 0);
            this.rtbOption.Name = "rtbOption";
            this.rtbOption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbOption.Size = new System.Drawing.Size(345, 28);
            this.rtbOption.TabIndex = 119;
            this.rtbOption.Text = "";
            this.rtbOption.TextChanged += new System.EventHandler(this.rtbOption_TextChanged);
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNumber.Location = new System.Drawing.Point(438, 3);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumber.Size = new System.Drawing.Size(36, 25);
            this.lblNumber.TabIndex = 121;
            // 
            // pbRemove
            // 
            this.pbRemove.Image = global::irQm.Properties.Resources.removemark;
            this.pbRemove.Location = new System.Drawing.Point(10, 2);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(20, 22);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemove.TabIndex = 120;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // cbIsTrue
            // 
            this.cbIsTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsTrue.AutoSize = true;
            this.cbIsTrue.Location = new System.Drawing.Point(36, 7);
            this.cbIsTrue.Name = "cbIsTrue";
            this.cbIsTrue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbIsTrue.Size = new System.Drawing.Size(15, 14);
            this.cbIsTrue.TabIndex = 122;
            this.cbIsTrue.UseVisualStyleBackColor = true;
            this.cbIsTrue.CheckedChanged += new System.EventHandler(this.cbIsTrue_CheckedChanged);
            // 
            // pbEdit
            // 
            this.pbEdit.Image = global::irQm.Properties.Resources.edit;
            this.pbEdit.Location = new System.Drawing.Point(59, 3);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(22, 21);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEdit.TabIndex = 123;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // UCOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.cbIsTrue);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.pbRemove);
            this.Controls.Add(this.rtbOption);
            this.Name = "UCOption";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(477, 31);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRemove;
        private CustomizedRichTextBox rtbOption;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.CheckBox cbIsTrue;
        private System.Windows.Forms.PictureBox pbEdit;
    }
}
