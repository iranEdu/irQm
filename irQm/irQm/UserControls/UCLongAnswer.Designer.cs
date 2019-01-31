using irQm.BaseCodes;
namespace irQm
{
    partial class UCLongAnswer
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
            this.txtFace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFace
            // 
            this.txtFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFace.Location = new System.Drawing.Point(0, 0);
            this.txtFace.Multiline = true;
            this.txtFace.Name = "txtFace";
            this.txtFace.Size = new System.Drawing.Size(477, 54);
            this.txtFace.TabIndex = 73;
            // 
            // UCLongAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFace);
            this.Name = "UCLongAnswer";
            this.Size = new System.Drawing.Size(477, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFace;
    }
}
