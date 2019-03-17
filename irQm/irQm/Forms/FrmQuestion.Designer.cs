namespace irQm.Forms
{
    partial class FrmQuestion
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
            this.showPanel = new System.Windows.Forms.Panel();
            this.ucQuestionForPresentation1 = new irQm.UserControls.qPresentation.UCQuestionForPresentation();
            this.btnEdit = new System.Windows.Forms.Button();
            this.showPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.btnEdit);
            this.showPanel.Controls.Add(this.ucQuestionForPresentation1);
            this.showPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPanel.Location = new System.Drawing.Point(0, 0);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(666, 497);
            this.showPanel.TabIndex = 3;
            // 
            // ucQuestionForPresentation1
            // 
            this.ucQuestionForPresentation1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucQuestionForPresentation1.AutoSize = true;
            this.ucQuestionForPresentation1.BackColor = System.Drawing.Color.Transparent;
            this.ucQuestionForPresentation1.Location = new System.Drawing.Point(119, -1);
            this.ucQuestionForPresentation1.Name = "ucQuestionForPresentation1";
            this.ucQuestionForPresentation1.Size = new System.Drawing.Size(547, 498);
            this.ucQuestionForPresentation1.TabIndex = 1;
            this.ucQuestionForPresentation1.Load += new System.EventHandler(this.ucQuestionForPresentation1_Load);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 151);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FrmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 497);
            this.Controls.Add(this.showPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQuestion";
            this.Text = "FrmQuestion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuestion_Load);
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel showPanel;
        private UserControls.qPresentation.UCQuestionForPresentation ucQuestionForPresentation1;
        private System.Windows.Forms.Button btnEdit;
    }
}