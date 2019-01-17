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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucOptionList1 = new irQm.UserControls.UCOptionList();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.cbMulti = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ucOptionList1);
            this.panel1.Controls.Add(this.pbAdd);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(522, 163);
            this.panel1.TabIndex = 116;
            // 
            // ucOptionList1
            // 
            this.ucOptionList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucOptionList1.AutoScroll = true;
            this.ucOptionList1.Location = new System.Drawing.Point(44, 2);
            this.ucOptionList1.MultiSelect = false;
            this.ucOptionList1.Name = "ucOptionList1";
            this.ucOptionList1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucOptionList1.Size = new System.Drawing.Size(477, 154);
            this.ucOptionList1.TabIndex = 111;
            // 
            // pbAdd
            // 
            this.pbAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAdd.Image = global::irQm.Properties.Resources.addmark;
            this.pbAdd.Location = new System.Drawing.Point(13, 119);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(25, 25);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 113;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // cbMulti
            // 
            this.cbMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMulti.AutoSize = true;
            this.cbMulti.Checked = true;
            this.cbMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMulti.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.cbMulti.Location = new System.Drawing.Point(352, 167);
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
            this.Controls.Add(this.panel1);
            this.Name = "UCMultiOption";
            this.Size = new System.Drawing.Size(521, 197);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAdd;
        private UserControls.UCOptionList ucOptionList1;
        private System.Windows.Forms.CheckBox cbMulti;
    }
}
