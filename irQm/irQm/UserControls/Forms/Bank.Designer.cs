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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.multiTabPage = new System.Windows.Forms.TabPage();
            this.tfTabPage = new System.Windows.Forms.TabPage();
            this.flpMultiOptionsQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.puzzleTabPage = new System.Windows.Forms.TabPage();
            this.shortTabPage = new System.Windows.Forms.TabPage();
            this.longTabPage = new System.Windows.Forms.TabPage();
            this.practicalTabPage = new System.Windows.Forms.TabPage();
            this.flpTFQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPuzzleQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.flpShortQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLongQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPracticalQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.multiTabPage.SuspendLayout();
            this.tfTabPage.SuspendLayout();
            this.puzzleTabPage.SuspendLayout();
            this.shortTabPage.SuspendLayout();
            this.longTabPage.SuspendLayout();
            this.practicalTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.multiTabPage);
            this.tabControl1.Controls.Add(this.tfTabPage);
            this.tabControl1.Controls.Add(this.puzzleTabPage);
            this.tabControl1.Controls.Add(this.shortTabPage);
            this.tabControl1.Controls.Add(this.longTabPage);
            this.tabControl1.Controls.Add(this.practicalTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 482);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // multiTabPage
            // 
            this.multiTabPage.Controls.Add(this.flpMultiOptionsQuestions);
            this.multiTabPage.Location = new System.Drawing.Point(4, 22);
            this.multiTabPage.Name = "multiTabPage";
            this.multiTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.multiTabPage.Size = new System.Drawing.Size(624, 456);
            this.multiTabPage.TabIndex = 0;
            this.multiTabPage.Text = "چند گزینه‌ای";
            this.multiTabPage.UseVisualStyleBackColor = true;
            // 
            // tfTabPage
            // 
            this.tfTabPage.Controls.Add(this.flpTFQuestions);
            this.tfTabPage.Location = new System.Drawing.Point(4, 22);
            this.tfTabPage.Name = "tfTabPage";
            this.tfTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tfTabPage.Size = new System.Drawing.Size(624, 456);
            this.tfTabPage.TabIndex = 1;
            this.tfTabPage.Text = "درست/ نادرست";
            this.tfTabPage.UseVisualStyleBackColor = true;
            // 
            // flpMultiOptionsQuestions
            // 
            this.flpMultiOptionsQuestions.AutoScroll = true;
            this.flpMultiOptionsQuestions.AutoSize = true;
            this.flpMultiOptionsQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMultiOptionsQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMultiOptionsQuestions.Location = new System.Drawing.Point(3, 3);
            this.flpMultiOptionsQuestions.Name = "flpMultiOptionsQuestions";
            this.flpMultiOptionsQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.flpMultiOptionsQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpMultiOptionsQuestions.Size = new System.Drawing.Size(618, 450);
            this.flpMultiOptionsQuestions.TabIndex = 144;
            this.flpMultiOptionsQuestions.WrapContents = false;
            // 
            // puzzleTabPage
            // 
            this.puzzleTabPage.Controls.Add(this.flpPuzzleQuestions);
            this.puzzleTabPage.Location = new System.Drawing.Point(4, 22);
            this.puzzleTabPage.Name = "puzzleTabPage";
            this.puzzleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.puzzleTabPage.Size = new System.Drawing.Size(624, 456);
            this.puzzleTabPage.TabIndex = 2;
            this.puzzleTabPage.Text = "جورکردنی";
            this.puzzleTabPage.UseVisualStyleBackColor = true;
            // 
            // shortTabPage
            // 
            this.shortTabPage.Controls.Add(this.flpShortQuestions);
            this.shortTabPage.Location = new System.Drawing.Point(4, 22);
            this.shortTabPage.Name = "shortTabPage";
            this.shortTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shortTabPage.Size = new System.Drawing.Size(624, 456);
            this.shortTabPage.TabIndex = 3;
            this.shortTabPage.Text = "کوتاه پاسخ";
            this.shortTabPage.UseVisualStyleBackColor = true;
            // 
            // longTabPage
            // 
            this.longTabPage.Controls.Add(this.flpLongQuestions);
            this.longTabPage.Location = new System.Drawing.Point(4, 22);
            this.longTabPage.Name = "longTabPage";
            this.longTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.longTabPage.Size = new System.Drawing.Size(624, 456);
            this.longTabPage.TabIndex = 4;
            this.longTabPage.Text = "بلند پاسخ";
            this.longTabPage.UseVisualStyleBackColor = true;
            // 
            // practicalTabPage
            // 
            this.practicalTabPage.Controls.Add(this.flpPracticalQuestions);
            this.practicalTabPage.Location = new System.Drawing.Point(4, 22);
            this.practicalTabPage.Name = "practicalTabPage";
            this.practicalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.practicalTabPage.Size = new System.Drawing.Size(624, 456);
            this.practicalTabPage.TabIndex = 5;
            this.practicalTabPage.Text = "عملی";
            this.practicalTabPage.UseVisualStyleBackColor = true;
            // 
            // flpTFQuestions
            // 
            this.flpTFQuestions.AutoScroll = true;
            this.flpTFQuestions.AutoSize = true;
            this.flpTFQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTFQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTFQuestions.Location = new System.Drawing.Point(3, 3);
            this.flpTFQuestions.Name = "flpTFQuestions";
            this.flpTFQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.flpTFQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpTFQuestions.Size = new System.Drawing.Size(618, 450);
            this.flpTFQuestions.TabIndex = 145;
            this.flpTFQuestions.WrapContents = false;
            // 
            // flpPuzzleQuestions
            // 
            this.flpPuzzleQuestions.AutoScroll = true;
            this.flpPuzzleQuestions.AutoSize = true;
            this.flpPuzzleQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPuzzleQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPuzzleQuestions.Location = new System.Drawing.Point(3, 3);
            this.flpPuzzleQuestions.Name = "flpPuzzleQuestions";
            this.flpPuzzleQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.flpPuzzleQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpPuzzleQuestions.Size = new System.Drawing.Size(618, 450);
            this.flpPuzzleQuestions.TabIndex = 145;
            this.flpPuzzleQuestions.WrapContents = false;
            // 
            // flpShortQuestions
            // 
            this.flpShortQuestions.AutoScroll = true;
            this.flpShortQuestions.AutoSize = true;
            this.flpShortQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpShortQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpShortQuestions.Location = new System.Drawing.Point(3, 3);
            this.flpShortQuestions.Name = "flpShortQuestions";
            this.flpShortQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.flpShortQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpShortQuestions.Size = new System.Drawing.Size(618, 450);
            this.flpShortQuestions.TabIndex = 145;
            this.flpShortQuestions.WrapContents = false;
            // 
            // flpLongQuestions
            // 
            this.flpLongQuestions.AutoScroll = true;
            this.flpLongQuestions.AutoSize = true;
            this.flpLongQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLongQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLongQuestions.Location = new System.Drawing.Point(3, 3);
            this.flpLongQuestions.Name = "flpLongQuestions";
            this.flpLongQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.flpLongQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpLongQuestions.Size = new System.Drawing.Size(618, 450);
            this.flpLongQuestions.TabIndex = 145;
            this.flpLongQuestions.WrapContents = false;
            // 
            // flpPracticalQuestions
            // 
            this.flpPracticalQuestions.AutoScroll = true;
            this.flpPracticalQuestions.AutoSize = true;
            this.flpPracticalQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPracticalQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPracticalQuestions.Location = new System.Drawing.Point(3, 3);
            this.flpPracticalQuestions.Name = "flpPracticalQuestions";
            this.flpPracticalQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.flpPracticalQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpPracticalQuestions.Size = new System.Drawing.Size(618, 450);
            this.flpPracticalQuestions.TabIndex = 145;
            this.flpPracticalQuestions.WrapContents = false;
            // 
            // Bank
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "Bank";
            this.Size = new System.Drawing.Size(632, 482);
            this.Load += new System.EventHandler(this.FrmBank_Load);
            this.tabControl1.ResumeLayout(false);
            this.multiTabPage.ResumeLayout(false);
            this.multiTabPage.PerformLayout();
            this.tfTabPage.ResumeLayout(false);
            this.tfTabPage.PerformLayout();
            this.puzzleTabPage.ResumeLayout(false);
            this.puzzleTabPage.PerformLayout();
            this.shortTabPage.ResumeLayout(false);
            this.shortTabPage.PerformLayout();
            this.longTabPage.ResumeLayout(false);
            this.longTabPage.PerformLayout();
            this.practicalTabPage.ResumeLayout(false);
            this.practicalTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage multiTabPage;
        private System.Windows.Forms.FlowLayoutPanel flpMultiOptionsQuestions;
        private System.Windows.Forms.TabPage tfTabPage;
        private System.Windows.Forms.FlowLayoutPanel flpTFQuestions;
        private System.Windows.Forms.TabPage puzzleTabPage;
        private System.Windows.Forms.FlowLayoutPanel flpPuzzleQuestions;
        private System.Windows.Forms.TabPage shortTabPage;
        private System.Windows.Forms.FlowLayoutPanel flpShortQuestions;
        private System.Windows.Forms.TabPage longTabPage;
        private System.Windows.Forms.FlowLayoutPanel flpLongQuestions;
        private System.Windows.Forms.TabPage practicalTabPage;
        private System.Windows.Forms.FlowLayoutPanel flpPracticalQuestions;
    }
}