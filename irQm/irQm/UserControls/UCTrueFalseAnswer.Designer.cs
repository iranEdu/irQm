namespace irQm
{
    partial class UCTrueFalseAnswer
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
            this.chbFalse = new System.Windows.Forms.RadioButton();
            this.chbTrue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chbFalse);
            this.panel1.Controls.Add(this.chbTrue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(522, 43);
            this.panel1.TabIndex = 116;
            // 
            // chbFalse
            // 
            this.chbFalse.AutoSize = true;
            this.chbFalse.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbFalse.Location = new System.Drawing.Point(334, 2);
            this.chbFalse.Name = "chbFalse";
            this.chbFalse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbFalse.Size = new System.Drawing.Size(53, 30);
            this.chbFalse.TabIndex = 115;
            this.chbFalse.TabStop = true;
            this.chbFalse.Text = "غلط";
            this.chbFalse.UseVisualStyleBackColor = true;
            // 
            // chbTrue
            // 
            this.chbTrue.AutoSize = true;
            this.chbTrue.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chbTrue.Location = new System.Drawing.Point(408, 2);
            this.chbTrue.Name = "chbTrue";
            this.chbTrue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbTrue.Size = new System.Drawing.Size(67, 30);
            this.chbTrue.TabIndex = 114;
            this.chbTrue.Text = "صحیح";
            this.chbTrue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(374, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(143, 35);
            this.label1.TabIndex = 111;
            this.label1.Text = "پاسخ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCTrueFalseAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCTrueFalseAnswer";
            this.Size = new System.Drawing.Size(531, 50);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton chbFalse;
        private System.Windows.Forms.RadioButton chbTrue;
    }
}
