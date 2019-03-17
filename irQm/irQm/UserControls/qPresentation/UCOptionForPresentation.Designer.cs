using irQm.BaseCodes;

namespace irQm.UserControls.qPresentation
{
    partial class UCOptionForPresentation
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
            this.cbIsTrue = new System.Windows.Forms.CheckBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.rbIsTrue = new System.Windows.Forms.RadioButton();
            this.FRtbFace = new irQm.BaseCodes.CustomizedRichTextBox();
            this.SuspendLayout();
            // 
            // cbIsTrue
            // 
            this.cbIsTrue.AutoSize = true;
            this.cbIsTrue.Location = new System.Drawing.Point(3, 5);
            this.cbIsTrue.Name = "cbIsTrue";
            this.cbIsTrue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbIsTrue.Size = new System.Drawing.Size(15, 14);
            this.cbIsTrue.TabIndex = 124;
            this.cbIsTrue.UseVisualStyleBackColor = true;
            this.cbIsTrue.CheckedChanged += new System.EventHandler(this.cbIsTrue_CheckedChanged);
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNumber.Location = new System.Drawing.Point(331, 3);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumber.Size = new System.Drawing.Size(27, 21);
            this.lblNumber.TabIndex = 123;
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbIsTrue
            // 
            this.rbIsTrue.AutoSize = true;
            this.rbIsTrue.Location = new System.Drawing.Point(3, 5);
            this.rbIsTrue.Name = "rbIsTrue";
            this.rbIsTrue.Size = new System.Drawing.Size(14, 13);
            this.rbIsTrue.TabIndex = 126;
            this.rbIsTrue.UseVisualStyleBackColor = true;
            this.rbIsTrue.CheckedChanged += new System.EventHandler(this.rbIsTrue_CheckedChanged);
            // 
            // FRtbFace
            // 
            this.FRtbFace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FRtbFace.BackColor = System.Drawing.Color.White;
            this.FRtbFace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FRtbFace.Location = new System.Drawing.Point(21, 3);
            this.FRtbFace.Name = "FRtbFace";
            this.FRtbFace.ReadOnly = true;
            this.FRtbFace.ShortcutsEnabled = false;
            this.FRtbFace.Size = new System.Drawing.Size(304, 18);
            this.FRtbFace.TabIndex = 125;
            this.FRtbFace.TabStop = false;
            this.FRtbFace.Text = "";
            // 
            // UCOptionForPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.CausesValidation = false;
            this.Controls.Add(this.rbIsTrue);
            this.Controls.Add(this.FRtbFace);
            this.Controls.Add(this.cbIsTrue);
            this.Controls.Add(this.lblNumber);
            this.Name = "UCOptionForPresentation";
            this.Size = new System.Drawing.Size(370, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIsTrue;
        private System.Windows.Forms.Label lblNumber;
        private  CustomizedRichTextBox FRtbFace;
        private System.Windows.Forms.RadioButton rbIsTrue;
    }
}
