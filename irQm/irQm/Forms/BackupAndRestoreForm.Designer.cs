namespace irQm.Forms
{
    partial class BackupAndRestoreForm
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
            this.components = new System.ComponentModel.Container();
            this.gbchooseoperation = new System.Windows.Forms.GroupBox();
            this.radioButtonrestore = new System.Windows.Forms.RadioButton();
            this.radiobuttonBackup = new System.Windows.Forms.RadioButton();
            this.gbbackup = new System.Windows.Forms.GroupBox();
            this.btnstopbackup = new System.Windows.Forms.Button();
            this.btnbackup = new System.Windows.Forms.Button();
            this.btnselectpath = new System.Windows.Forms.Button();
            this.txtbackupname = new System.Windows.Forms.TextBox();
            this.txtselectpath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbrestore = new System.Windows.Forms.GroupBox();
            this.btnrestore = new System.Windows.Forms.Button();
            this.btnchoosefile = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbchooseoperation.SuspendLayout();
            this.gbbackup.SuspendLayout();
            this.gbrestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbchooseoperation
            // 
            this.gbchooseoperation.Controls.Add(this.radioButtonrestore);
            this.gbchooseoperation.Controls.Add(this.radiobuttonBackup);
            this.gbchooseoperation.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbchooseoperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbchooseoperation.Location = new System.Drawing.Point(25, 46);
            this.gbchooseoperation.Name = "gbchooseoperation";
            this.gbchooseoperation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbchooseoperation.Size = new System.Drawing.Size(531, 88);
            this.gbchooseoperation.TabIndex = 138;
            this.gbchooseoperation.TabStop = false;
            this.gbchooseoperation.Text = "انتخاب عملیات";
            // 
            // radioButtonrestore
            // 
            this.radioButtonrestore.AutoSize = true;
            this.radioButtonrestore.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButtonrestore.Location = new System.Drawing.Point(226, 33);
            this.radioButtonrestore.Name = "radioButtonrestore";
            this.radioButtonrestore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonrestore.Size = new System.Drawing.Size(106, 28);
            this.radioButtonrestore.TabIndex = 1;
            this.radioButtonrestore.TabStop = true;
            this.radioButtonrestore.Text = "بازیابی اطلاعات";
            this.radioButtonrestore.UseVisualStyleBackColor = true;
            // 
            // radiobuttonBackup
            // 
            this.radiobuttonBackup.AutoSize = true;
            this.radiobuttonBackup.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radiobuttonBackup.Location = new System.Drawing.Point(422, 33);
            this.radiobuttonBackup.Name = "radiobuttonBackup";
            this.radiobuttonBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobuttonBackup.Size = new System.Drawing.Size(97, 28);
            this.radiobuttonBackup.TabIndex = 0;
            this.radiobuttonBackup.TabStop = true;
            this.radiobuttonBackup.Text = "پشیبان گیری";
            this.radiobuttonBackup.UseVisualStyleBackColor = true;
            this.radiobuttonBackup.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbbackup
            // 
            this.gbbackup.Controls.Add(this.btnstopbackup);
            this.gbbackup.Controls.Add(this.btnbackup);
            this.gbbackup.Controls.Add(this.btnselectpath);
            this.gbbackup.Controls.Add(this.txtbackupname);
            this.gbbackup.Controls.Add(this.txtselectpath);
            this.gbbackup.Controls.Add(this.label5);
            this.gbbackup.Controls.Add(this.label4);
            this.gbbackup.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbbackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbbackup.Location = new System.Drawing.Point(25, 149);
            this.gbbackup.Name = "gbbackup";
            this.gbbackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbbackup.Size = new System.Drawing.Size(531, 163);
            this.gbbackup.TabIndex = 139;
            this.gbbackup.TabStop = false;
            this.gbbackup.Text = "تهیه نسخه پشتیبان";
            // 
            // btnstopbackup
            // 
            this.btnstopbackup.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnstopbackup.ForeColor = System.Drawing.Color.Black;
            this.btnstopbackup.Location = new System.Drawing.Point(49, 105);
            this.btnstopbackup.Name = "btnstopbackup";
            this.btnstopbackup.Size = new System.Drawing.Size(99, 29);
            this.btnstopbackup.TabIndex = 142;
            this.btnstopbackup.Text = "توقف";
            this.btnstopbackup.UseVisualStyleBackColor = true;
            // 
            // btnbackup
            // 
            this.btnbackup.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnbackup.ForeColor = System.Drawing.Color.Black;
            this.btnbackup.Location = new System.Drawing.Point(154, 105);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(96, 29);
            this.btnbackup.TabIndex = 141;
            this.btnbackup.Text = "پشتیبان گیری";
            this.btnbackup.UseVisualStyleBackColor = true;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // btnselectpath
            // 
            this.btnselectpath.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnselectpath.ForeColor = System.Drawing.Color.Black;
            this.btnselectpath.Location = new System.Drawing.Point(49, 31);
            this.btnselectpath.Name = "btnselectpath";
            this.btnselectpath.Size = new System.Drawing.Size(32, 25);
            this.btnselectpath.TabIndex = 140;
            this.btnselectpath.Text = "...";
            this.btnselectpath.UseVisualStyleBackColor = true;
            this.btnselectpath.Click += new System.EventHandler(this.btnselectpath_Click);
            // 
            // txtbackupname
            // 
            this.txtbackupname.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtbackupname.Location = new System.Drawing.Point(87, 70);
            this.txtbackupname.Multiline = true;
            this.txtbackupname.Name = "txtbackupname";
            this.txtbackupname.Size = new System.Drawing.Size(275, 23);
            this.txtbackupname.TabIndex = 3;
            // 
            // txtselectpath
            // 
            this.txtselectpath.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtselectpath.Location = new System.Drawing.Point(87, 32);
            this.txtselectpath.Multiline = true;
            this.txtselectpath.Name = "txtselectpath";
            this.txtselectpath.Size = new System.Drawing.Size(275, 23);
            this.txtselectpath.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(418, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "نام فایل پشتیبان:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(368, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "مسیر ذخیره فایل پشتیبان:";
            // 
            // gbrestore
            // 
            this.gbrestore.Controls.Add(this.btnrestore);
            this.gbrestore.Controls.Add(this.btnchoosefile);
            this.gbrestore.Controls.Add(this.textBox4);
            this.gbrestore.Controls.Add(this.label7);
            this.gbrestore.Font = new System.Drawing.Font("B Titr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbrestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbrestore.Location = new System.Drawing.Point(25, 321);
            this.gbrestore.Name = "gbrestore";
            this.gbrestore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbrestore.Size = new System.Drawing.Size(531, 126);
            this.gbrestore.TabIndex = 143;
            this.gbrestore.TabStop = false;
            this.gbrestore.Text = "بازیابی فایل پشتیبان";
            // 
            // btnrestore
            // 
            this.btnrestore.Font = new System.Drawing.Font("B Titr", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnrestore.ForeColor = System.Drawing.Color.Black;
            this.btnrestore.Location = new System.Drawing.Point(49, 79);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(99, 29);
            this.btnrestore.TabIndex = 142;
            this.btnrestore.Text = "بازیابی";
            this.btnrestore.UseVisualStyleBackColor = true;
            // 
            // btnchoosefile
            // 
            this.btnchoosefile.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnchoosefile.ForeColor = System.Drawing.Color.Black;
            this.btnchoosefile.Location = new System.Drawing.Point(49, 31);
            this.btnchoosefile.Name = "btnchoosefile";
            this.btnchoosefile.Size = new System.Drawing.Size(32, 25);
            this.btnchoosefile.TabIndex = 140;
            this.btnchoosefile.Text = "...";
            this.btnchoosefile.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox4.Location = new System.Drawing.Point(87, 32);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(275, 23);
            this.textBox4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(404, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "مسیر فایل پشتیبان:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BackupAndRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gbrestore);
            this.Controls.Add(this.gbbackup);
            this.Controls.Add(this.gbchooseoperation);
            this.Name = "BackupAndRestoreForm";
            this.Text = "BackupAndRestoreForm";
            this.Controls.SetChildIndex(this.gbchooseoperation, 0);
            this.Controls.SetChildIndex(this.gbbackup, 0);
            this.Controls.SetChildIndex(this.gbrestore, 0);
            this.gbchooseoperation.ResumeLayout(false);
            this.gbchooseoperation.PerformLayout();
            this.gbbackup.ResumeLayout(false);
            this.gbbackup.PerformLayout();
            this.gbrestore.ResumeLayout(false);
            this.gbrestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbchooseoperation;
        private System.Windows.Forms.RadioButton radiobuttonBackup;
        private System.Windows.Forms.RadioButton radioButtonrestore;
        private System.Windows.Forms.GroupBox gbbackup;
        private System.Windows.Forms.Button btnstopbackup;
        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Button btnselectpath;
        private System.Windows.Forms.TextBox txtbackupname;
        private System.Windows.Forms.TextBox txtselectpath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbrestore;
        private System.Windows.Forms.Button btnrestore;
        private System.Windows.Forms.Button btnchoosefile;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}