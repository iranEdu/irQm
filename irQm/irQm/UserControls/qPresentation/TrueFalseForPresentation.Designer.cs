namespace irQm.UserControls.qPresentation
{
    partial class TrueFalseForPresentation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.chbFalse = new System.Windows.Forms.RadioButton();
            this.chbTrue = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.chbFalse);
            this.panel1.Controls.Add(this.chbTrue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 34);
            this.panel1.TabIndex = 118;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(31, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 121;
            this.btnClear.Text = "پاک سازی";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chbFalse
            // 
            this.chbFalse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFalse.AutoSize = true;
            this.chbFalse.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbFalse.Location = new System.Drawing.Point(158, 0);
            this.chbFalse.Name = "chbFalse";
            this.chbFalse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbFalse.Size = new System.Drawing.Size(53, 30);
            this.chbFalse.TabIndex = 120;
            this.chbFalse.Text = "غلط";
            this.chbFalse.UseVisualStyleBackColor = true;
            this.chbFalse.CheckedChanged += new System.EventHandler(this.chbFalse_CheckedChanged);
            // 
            // chbTrue
            // 
            this.chbTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbTrue.AutoSize = true;
            this.chbTrue.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbTrue.Location = new System.Drawing.Point(217, 0);
            this.chbTrue.Name = "chbTrue";
            this.chbTrue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbTrue.Size = new System.Drawing.Size(67, 30);
            this.chbTrue.TabIndex = 119;
            this.chbTrue.Text = "صحیح";
            this.chbTrue.UseVisualStyleBackColor = true;
            this.chbTrue.CheckedChanged += new System.EventHandler(this.chbTrue_CheckedChanged);
            // 
            // TrueFalseForPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TrueFalseForPresentation";
            this.Size = new System.Drawing.Size(287, 34);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton chbFalse;
        private System.Windows.Forms.RadioButton chbTrue;
        private System.Windows.Forms.Button btnClear;
    }
}
