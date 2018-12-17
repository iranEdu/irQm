namespace irQm
{
    partial class UCMultiOption
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
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucOptionList1 = new irQm.UserControls.UCOptionList();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richtxtmultianswer = new System.Windows.Forms.RichTextBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEntire = new System.Windows.Forms.Button();
            this.cbMulti = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnNew.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(8, 340);
            this.btnNew.Name = "btnNew";
            this.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 118;
            this.btnNew.Text = "+ جدید";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ucOptionList1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.richtxtmultianswer);
            this.panel1.Controls.Add(this.pbAdd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(522, 332);
            this.panel1.TabIndex = 116;
            // 
            // ucOptionList1
            // 
            this.ucOptionList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucOptionList1.AutoScroll = true;
            this.ucOptionList1.Location = new System.Drawing.Point(39, 166);
            this.ucOptionList1.MultiSelect = false;
            this.ucOptionList1.Name = "ucOptionList1";
            this.ucOptionList1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucOptionList1.Size = new System.Drawing.Size(477, 154);
            this.ucOptionList1.TabIndex = 111;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::irQm.Properties.Resources.edit;
            this.pictureBox1.Location = new System.Drawing.Point(9, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // richtxtmultianswer
            // 
            this.richtxtmultianswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtxtmultianswer.Location = new System.Drawing.Point(39, 64);
            this.richtxtmultianswer.Name = "richtxtmultianswer";
            this.richtxtmultianswer.Size = new System.Drawing.Size(459, 96);
            this.richtxtmultianswer.TabIndex = 75;
            this.richtxtmultianswer.Text = "";
            // 
            // pbAdd
            // 
            this.pbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAdd.Image = global::irQm.Properties.Resources.addmark;
            this.pbAdd.Location = new System.Drawing.Point(8, 283);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(25, 25);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 113;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(457, 35);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(46, 35);
            this.label7.TabIndex = 74;
            this.label7.Text = "سوال:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-1, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(522, 35);
            this.label5.TabIndex = 72;
            this.label5.Text = "+ ثبت سوال چندگزینه‌ای";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtnEntire
            // 
            this.BtnEntire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.BtnEntire.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnEntire.ForeColor = System.Drawing.Color.White;
            this.BtnEntire.Location = new System.Drawing.Point(101, 340);
            this.BtnEntire.Name = "BtnEntire";
            this.BtnEntire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnEntire.Size = new System.Drawing.Size(85, 39);
            this.BtnEntire.TabIndex = 117;
            this.BtnEntire.Text = " ثبت";
            this.BtnEntire.UseVisualStyleBackColor = false;
            // 
            // cbMulti
            // 
            this.cbMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMulti.AutoSize = true;
            this.cbMulti.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.cbMulti.Location = new System.Drawing.Point(352, 345);
            this.cbMulti.Name = "cbMulti";
            this.cbMulti.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbMulti.Size = new System.Drawing.Size(166, 30);
            this.cbMulti.TabIndex = 119;
            this.cbMulti.Text = "امکان انتخاب چند گزینه";
            this.cbMulti.UseVisualStyleBackColor = true;
            this.cbMulti.CheckedChanged += new System.EventHandler(this.cbMulti_CheckedChanged);
            // 
            // UCMultiOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMulti);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnEntire);
            this.Name = "UCMultiOption";
            this.Size = new System.Drawing.Size(521, 389);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richtxtmultianswer;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEntire;
        private UserControls.UCOptionList ucOptionList1;
        private System.Windows.Forms.CheckBox cbMulti;
    }
}
