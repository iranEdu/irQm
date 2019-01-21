﻿using irQm.BaseCodes;
namespace irQm
{
    partial class UCPuzzleOption
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
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.textFirstpair = new System.Windows.Forms.TextBox();
            this.TextSecondpair = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRemove
            // 
            this.pbRemove.Image = global::irQm.Properties.Resources.removemark;
            this.pbRemove.Location = new System.Drawing.Point(3, 1);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(20, 22);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemove.TabIndex = 121;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumber.Location = new System.Drawing.Point(426, 1);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumber.Size = new System.Drawing.Size(33, 23);
            this.lblNumber.TabIndex = 122;
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textFirstpair
            // 
            this.textFirstpair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFirstpair.Location = new System.Drawing.Point(216, 3);
            this.textFirstpair.Name = "textFirstpair";
            this.textFirstpair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textFirstpair.Size = new System.Drawing.Size(204, 20);
            this.textFirstpair.TabIndex = 123;
            this.textFirstpair.Text = "";
            this.textFirstpair.TextChanged += new System.EventHandler(this.txtcolumn1_TextChanged);
            // 
            // TextSecondpair
            // 
            this.TextSecondpair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSecondpair.Location = new System.Drawing.Point(29, 3);
            this.TextSecondpair.Name = "TextSecondpair";
            this.TextSecondpair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextSecondpair.Size = new System.Drawing.Size(181, 20);
            this.TextSecondpair.TabIndex = 124;
            this.TextSecondpair.Text = "";
            this.TextSecondpair.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // UCPuzzleOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextSecondpair);
            this.Controls.Add(this.textFirstpair);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.pbRemove);
            this.Name = "UCPuzzleOption";
            this.Size = new System.Drawing.Size(476, 30);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox textFirstpair;
        private System.Windows.Forms.TextBox TextSecondpair;
    }
        
}
