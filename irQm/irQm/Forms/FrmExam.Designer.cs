namespace irQm.Forms
{
    partial class FrmExam
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
            irQm.BaseCodes.MultiChoices multiChoices1 = new irQm.BaseCodes.MultiChoices();
            this.ucQuestionForPresentation1 = new irQm.UCQuestionForPresentation();
            this.SuspendLayout();
            // 
            // ucQuestionForPresentation1
            // 
            this.ucQuestionForPresentation1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucQuestionForPresentation1.AutoScroll = true;
            this.ucQuestionForPresentation1.AutoSize = true;
            this.ucQuestionForPresentation1.BackColor = System.Drawing.Color.White;
            this.ucQuestionForPresentation1.Location = new System.Drawing.Point(12, 99);
            this.ucQuestionForPresentation1.Name = "ucQuestionForPresentation1";
            multiChoices1.CreatorUser = null;
            multiChoices1.CreatorUserId = null;
            multiChoices1.EditTime = new System.DateTime(((long)(0)));
            multiChoices1.Face = null;
            multiChoices1.GainedScore = 0F;
            multiChoices1.Id = null;
            multiChoices1.Image = null;
            multiChoices1.JustInList = false;
            multiChoices1.Lesson = null;
            multiChoices1.LessonName = null;
            multiChoices1.MultiSelections = false;
            multiChoices1.Options = null;
            multiChoices1.RegisterTime = new System.DateTime(((long)(0)));
            multiChoices1.Score = 0F;
            multiChoices1.Tags = null;
            this.ucQuestionForPresentation1.Question = multiChoices1;
            this.ucQuestionForPresentation1.Size = new System.Drawing.Size(565, 303);
            this.ucQuestionForPresentation1.TabIndex = 138;
            // 
            // FrmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ucQuestionForPresentation1);
            this.Name = "FrmExam";
            this.Text = "FrmExam";
            this.Controls.SetChildIndex(this.ucQuestionForPresentation1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCQuestionForPresentation ucQuestionForPresentation1;
        
    }
}