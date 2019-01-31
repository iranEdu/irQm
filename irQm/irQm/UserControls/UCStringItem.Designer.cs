using irQm.BaseCodes;
using irQm.UserControls.Utilities;

namespace irQm.UserControls
{
    partial class UCStringItem
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
            this.textCheckList = new AutoDirectionTextbox();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // textCheckList
            // 
            this.textCheckList.Location = new System.Drawing.Point(36, 9);
            this.textCheckList.Name = "textCheckList";
            this.textCheckList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textCheckList.Size = new System.Drawing.Size(315, 20);
            this.textCheckList.TabIndex = 0;
            this.textCheckList.TextChanged += new System.EventHandler(this.txtCheckList_TextChanged);
            // 
            // pbRemove
            // 
            this.pbRemove.Image = global::irQm.Properties.Resources.removemark;
            this.pbRemove.Location = new System.Drawing.Point(10, 7);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(20, 22);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemove.TabIndex = 124;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(357, 9);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumber.Size = new System.Drawing.Size(24, 23);
            this.lblNumber.TabIndex = 126;
            this.lblNumber.Text = " ";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCStringItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.pbRemove);
            this.Controls.Add(this.textCheckList);
            this.Name = "UCStringItem";
            this.Size = new System.Drawing.Size(395, 37);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoDirectionTextbox textCheckList;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.Label lblNumber;
    }
}
