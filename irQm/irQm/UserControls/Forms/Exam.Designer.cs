using irQm.UserControls.qPresentation;

namespace irQm.UserControls.Forms
{
    partial class Exam
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
            this.ucQuestionForPresentation1 = new irQm.UserControls.qPresentation.UCQuestionForPresentation();
            this.SuspendLayout();
            // 
            // ucQuestionForPresentation1
            // 
            this.ucQuestionForPresentation1.AutoScroll = true;
            this.ucQuestionForPresentation1.AutoSize = true;
            this.ucQuestionForPresentation1.BackColor = System.Drawing.Color.White;
            this.ucQuestionForPresentation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuestionForPresentation1.Location = new System.Drawing.Point(0, 0);
            this.ucQuestionForPresentation1.Name = "ucQuestionForPresentation1";
            this.ucQuestionForPresentation1.Size = new System.Drawing.Size(489, 155);
            this.ucQuestionForPresentation1.TabIndex = 138;
            // 
            // FrmExam
            // 
            this.Controls.Add(this.ucQuestionForPresentation1);
            this.Name = "FrmExam";
            this.Size = new System.Drawing.Size(489, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCQuestionForPresentation ucQuestionForPresentation1;
        
    }
}