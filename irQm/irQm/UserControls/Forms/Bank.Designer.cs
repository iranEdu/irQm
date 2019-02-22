namespace irQm.UserControls.Forms
{
    partial class Bank
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
            this.flpQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpQuestions
            // 
            this.flpQuestions.AutoScroll = true;
            this.flpQuestions.AutoSize = true;
            this.flpQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpQuestions.Location = new System.Drawing.Point(0, 0);
            this.flpQuestions.Name = "flpQuestions";
            this.flpQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.flpQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpQuestions.Size = new System.Drawing.Size(632, 482);
            this.flpQuestions.TabIndex = 143;
            this.flpQuestions.WrapContents = false;
            // 
            // FrmBank
            // 
            this.Controls.Add(this.flpQuestions);
            this.Name = "FrmBank";
            this.Size = new System.Drawing.Size(632, 482);
            this.Load += new System.EventHandler(this.FrmBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpQuestions;
    }
}