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
            this.flpMultiOptionsQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.tfTabPage = new System.Windows.Forms.TabPage();
            this.flpTFQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.puzzleTabPage = new System.Windows.Forms.TabPage();
            this.flpPuzzleQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.shortTabPage = new System.Windows.Forms.TabPage();
            this.flpShortQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.longTabPage = new System.Windows.Forms.TabPage();
            this.flpLongQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.practicalTabPage = new System.Windows.Forms.TabPage();
            this.flpPracticalQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectedQuestionsTabPage = new System.Windows.Forms.TabPage();
            this.flpSelectedQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.toolsTabControl = new System.Windows.Forms.TabControl();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMakeExam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fdpTo = new FarsiLibrary.Win.Controls.FADatePicker();
            this.fdpFrom = new FarsiLibrary.Win.Controls.FADatePicker();
            this.lessonsComboBox1 = new irQm.UserControls.Utilities.LessonsComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tagsBox1 = new irQm.TagsBox();
            this.txtSearchExpr = new irQm.UserControls.Utilities.AutoDirectionTextbox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OperationsTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.multiTabPage.SuspendLayout();
            this.tfTabPage.SuspendLayout();
            this.puzzleTabPage.SuspendLayout();
            this.shortTabPage.SuspendLayout();
            this.longTabPage.SuspendLayout();
            this.practicalTabPage.SuspendLayout();
            this.SelectedQuestionsTabPage.SuspendLayout();
            this.toolsTabControl.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.multiTabPage);
            this.tabControl1.Controls.Add(this.tfTabPage);
            this.tabControl1.Controls.Add(this.puzzleTabPage);
            this.tabControl1.Controls.Add(this.shortTabPage);
            this.tabControl1.Controls.Add(this.longTabPage);
            this.tabControl1.Controls.Add(this.practicalTabPage);
            this.tabControl1.Controls.Add(this.SelectedQuestionsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 355);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // multiTabPage
            // 
            this.multiTabPage.Controls.Add(this.flpMultiOptionsQuestions);
            this.multiTabPage.Location = new System.Drawing.Point(4, 22);
            this.multiTabPage.Name = "multiTabPage";
            this.multiTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.multiTabPage.Size = new System.Drawing.Size(624, 329);
            this.multiTabPage.TabIndex = 0;
            this.multiTabPage.Text = "چند گزینه‌ای";
            this.multiTabPage.UseVisualStyleBackColor = true;
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
            this.flpMultiOptionsQuestions.Size = new System.Drawing.Size(618, 323);
            this.flpMultiOptionsQuestions.TabIndex = 144;
            this.flpMultiOptionsQuestions.WrapContents = false;
            // 
            // tfTabPage
            // 
            this.tfTabPage.Controls.Add(this.flpTFQuestions);
            this.tfTabPage.Location = new System.Drawing.Point(4, 22);
            this.tfTabPage.Name = "tfTabPage";
            this.tfTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tfTabPage.Size = new System.Drawing.Size(624, 329);
            this.tfTabPage.TabIndex = 1;
            this.tfTabPage.Text = "درست/ نادرست";
            this.tfTabPage.UseVisualStyleBackColor = true;
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
            this.flpTFQuestions.Size = new System.Drawing.Size(618, 323);
            this.flpTFQuestions.TabIndex = 145;
            this.flpTFQuestions.WrapContents = false;
            // 
            // puzzleTabPage
            // 
            this.puzzleTabPage.Controls.Add(this.flpPuzzleQuestions);
            this.puzzleTabPage.Location = new System.Drawing.Point(4, 22);
            this.puzzleTabPage.Name = "puzzleTabPage";
            this.puzzleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.puzzleTabPage.Size = new System.Drawing.Size(624, 329);
            this.puzzleTabPage.TabIndex = 2;
            this.puzzleTabPage.Text = "جورکردنی";
            this.puzzleTabPage.UseVisualStyleBackColor = true;
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
            this.flpPuzzleQuestions.Size = new System.Drawing.Size(618, 323);
            this.flpPuzzleQuestions.TabIndex = 145;
            this.flpPuzzleQuestions.WrapContents = false;
            // 
            // shortTabPage
            // 
            this.shortTabPage.Controls.Add(this.flpShortQuestions);
            this.shortTabPage.Location = new System.Drawing.Point(4, 22);
            this.shortTabPage.Name = "shortTabPage";
            this.shortTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shortTabPage.Size = new System.Drawing.Size(624, 329);
            this.shortTabPage.TabIndex = 3;
            this.shortTabPage.Text = "کوتاه پاسخ";
            this.shortTabPage.UseVisualStyleBackColor = true;
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
            this.flpShortQuestions.Size = new System.Drawing.Size(618, 323);
            this.flpShortQuestions.TabIndex = 145;
            this.flpShortQuestions.WrapContents = false;
            // 
            // longTabPage
            // 
            this.longTabPage.Controls.Add(this.flpLongQuestions);
            this.longTabPage.Location = new System.Drawing.Point(4, 22);
            this.longTabPage.Name = "longTabPage";
            this.longTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.longTabPage.Size = new System.Drawing.Size(624, 329);
            this.longTabPage.TabIndex = 4;
            this.longTabPage.Text = "بلند پاسخ";
            this.longTabPage.UseVisualStyleBackColor = true;
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
            this.flpLongQuestions.Size = new System.Drawing.Size(618, 323);
            this.flpLongQuestions.TabIndex = 145;
            this.flpLongQuestions.WrapContents = false;
            // 
            // practicalTabPage
            // 
            this.practicalTabPage.Controls.Add(this.flpPracticalQuestions);
            this.practicalTabPage.Location = new System.Drawing.Point(4, 22);
            this.practicalTabPage.Name = "practicalTabPage";
            this.practicalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.practicalTabPage.Size = new System.Drawing.Size(624, 329);
            this.practicalTabPage.TabIndex = 5;
            this.practicalTabPage.Text = "عملی";
            this.practicalTabPage.UseVisualStyleBackColor = true;
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
            this.flpPracticalQuestions.Size = new System.Drawing.Size(618, 323);
            this.flpPracticalQuestions.TabIndex = 145;
            this.flpPracticalQuestions.WrapContents = false;
            // 
            // SelectedQuestionsTabPage
            // 
            this.SelectedQuestionsTabPage.Controls.Add(this.flpSelectedQuestions);
            this.SelectedQuestionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SelectedQuestionsTabPage.Name = "SelectedQuestionsTabPage";
            this.SelectedQuestionsTabPage.Size = new System.Drawing.Size(624, 329);
            this.SelectedQuestionsTabPage.TabIndex = 6;
            this.SelectedQuestionsTabPage.Text = "انتخاب شده‌ها";
            this.SelectedQuestionsTabPage.UseVisualStyleBackColor = true;
            // 
            // flpSelectedQuestions
            // 
            this.flpSelectedQuestions.AllowDrop = true;
            this.flpSelectedQuestions.AutoScroll = true;
            this.flpSelectedQuestions.AutoSize = true;
            this.flpSelectedQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSelectedQuestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSelectedQuestions.Location = new System.Drawing.Point(0, 0);
            this.flpSelectedQuestions.Name = "flpSelectedQuestions";
            this.flpSelectedQuestions.Padding = new System.Windows.Forms.Padding(5);
            this.flpSelectedQuestions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpSelectedQuestions.Size = new System.Drawing.Size(624, 329);
            this.flpSelectedQuestions.TabIndex = 146;
            this.flpSelectedQuestions.WrapContents = false;
            this.flpSelectedQuestions.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpSelectedQuestions_DragDrop);
            this.flpSelectedQuestions.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpSelectedQuestions_DragEnter);
            this.flpSelectedQuestions.DragOver += new System.Windows.Forms.DragEventHandler(this.flpSelectedQuestions_DragOver);
            // 
            // toolsTabControl
            // 
            this.toolsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsTabControl.Controls.Add(this.searchTabPage);
            this.toolsTabControl.Controls.Add(this.OperationsTabPage);
            this.toolsTabControl.Location = new System.Drawing.Point(17, 3);
            this.toolsTabControl.Name = "toolsTabControl";
            this.toolsTabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolsTabControl.RightToLeftLayout = true;
            this.toolsTabControl.SelectedIndex = 0;
            this.toolsTabControl.Size = new System.Drawing.Size(594, 109);
            this.toolsTabControl.TabIndex = 2;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.panel1);
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchTabPage.Size = new System.Drawing.Size(586, 83);
            this.searchTabPage.TabIndex = 0;
            this.searchTabPage.Text = "جستجو";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMakeExam);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fdpTo);
            this.panel1.Controls.Add(this.fdpFrom);
            this.panel1.Controls.Add(this.lessonsComboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tagsBox1);
            this.panel1.Controls.Add(this.txtSearchExpr);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 77);
            this.panel1.TabIndex = 2;
            // 
            // btnMakeExam
            // 
            this.btnMakeExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMakeExam.Location = new System.Drawing.Point(3, 53);
            this.btnMakeExam.Name = "btnMakeExam";
            this.btnMakeExam.Size = new System.Drawing.Size(151, 23);
            this.btnMakeExam.TabIndex = 12;
            this.btnMakeExam.Text = "ایجاد آزمون از انتخاب شده‌ها";
            this.btnMakeExam.UseVisualStyleBackColor = true;
            this.btnMakeExam.Click += new System.EventHandler(this.btnMakeExam_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 36);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "تا:";
            // 
            // fdpTo
            // 
            this.fdpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpTo.Location = new System.Drawing.Point(197, 29);
            this.fdpTo.Name = "fdpTo";
            this.fdpTo.Size = new System.Drawing.Size(120, 20);
            this.fdpTo.TabIndex = 10;
            // 
            // fdpFrom
            // 
            this.fdpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fdpFrom.Location = new System.Drawing.Point(376, 29);
            this.fdpFrom.Name = "fdpFrom";
            this.fdpFrom.Size = new System.Drawing.Size(120, 20);
            this.fdpFrom.TabIndex = 9;
            // 
            // lessonsComboBox1
            // 
            this.lessonsComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lessonsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonsComboBox1.FormattingEnabled = true;
            this.lessonsComboBox1.Location = new System.Drawing.Point(375, 55);
            this.lessonsComboBox1.Name = "lessonsComboBox1";
            this.lessonsComboBox1.Size = new System.Drawing.Size(121, 21);
            this.lessonsComboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 36);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاریخ از:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 58);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "درس:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 6);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "برچسب:";
            // 
            // tagsBox1
            // 
            this.tagsBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tagsBox1.Location = new System.Drawing.Point(70, 3);
            this.tagsBox1.Name = "tagsBox1";
            this.tagsBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tagsBox1.Size = new System.Drawing.Size(247, 20);
            this.tagsBox1.TabIndex = 4;
            this.tagsBox1.Tags = new string[0];
            // 
            // txtSearchExpr
            // 
            this.txtSearchExpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchExpr.Location = new System.Drawing.Point(372, 3);
            this.txtSearchExpr.Name = "txtSearchExpr";
            this.txtSearchExpr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchExpr.Size = new System.Drawing.Size(124, 20);
            this.txtSearchExpr.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(160, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "عبارت جستجو:";
            // 
            // OperationsTabPage
            // 
            this.OperationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.OperationsTabPage.Name = "OperationsTabPage";
            this.OperationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OperationsTabPage.Size = new System.Drawing.Size(586, 83);
            this.OperationsTabPage.TabIndex = 1;
            this.OperationsTabPage.Text = "عملیات";
            this.OperationsTabPage.UseVisualStyleBackColor = true;
            // 
            // Bank
            // 
            this.Controls.Add(this.toolsTabControl);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bank";
            this.Size = new System.Drawing.Size(632, 482);
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
            this.SelectedQuestionsTabPage.ResumeLayout(false);
            this.SelectedQuestionsTabPage.PerformLayout();
            this.toolsTabControl.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TabControl toolsTabControl;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private FarsiLibrary.Win.Controls.FADatePicker fdpTo;
        private FarsiLibrary.Win.Controls.FADatePicker fdpFrom;
        private Utilities.LessonsComboBox lessonsComboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private TagsBox tagsBox1;
        private Utilities.AutoDirectionTextbox txtSearchExpr;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage OperationsTabPage;
        private System.Windows.Forms.TabPage SelectedQuestionsTabPage;
        private System.Windows.Forms.Button btnMakeExam;
        private System.Windows.Forms.FlowLayoutPanel flpSelectedQuestions;
    }
}