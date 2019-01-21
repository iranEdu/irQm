namespace irQm.Forms
{
    partial class FrmEdit
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
            this.richTxtEdit = new irQm.BaseCodes.CustomizedRichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsuperscript = new System.Windows.Forms.Label();
            this.lblSubscript = new System.Windows.Forms.Label();
            this.lblPaste = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblCut = new System.Windows.Forms.Label();
            this.lblPictures = new System.Windows.Forms.Label();
            this.lblRightToLeft = new System.Windows.Forms.Label();
            this.lblLeftToRight = new System.Windows.Forms.Label();
            this.lblFontColor = new System.Windows.Forms.Label();
            this.lblUnderline = new System.Windows.Forms.Label();
            this.lblItalic = new System.Windows.Forms.Label();
            this.lblBold = new System.Windows.Forms.Label();
            this.lblJustify = new System.Windows.Forms.Label();
            this.lblAlignL = new System.Windows.Forms.Label();
            this.LblalignR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRedo = new System.Windows.Forms.Label();
            this.lblUndo = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTxtPic = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxtEdit
            // 
            this.richTxtEdit.Location = new System.Drawing.Point(12, 178);
            this.richTxtEdit.Name = "richTxtEdit";
            this.richTxtEdit.Size = new System.Drawing.Size(379, 265);
            this.richTxtEdit.TabIndex = 51;
            this.richTxtEdit.Text = "";
            this.richTxtEdit.SelectionChanged += new System.EventHandler(this.richTxtEdit_SelectionChanged);
            this.richTxtEdit.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTxtEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTxtEdit_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblsuperscript);
            this.panel2.Controls.Add(this.lblSubscript);
            this.panel2.Controls.Add(this.lblPaste);
            this.panel2.Controls.Add(this.lblCopy);
            this.panel2.Controls.Add(this.lblCut);
            this.panel2.Controls.Add(this.lblPictures);
            this.panel2.Controls.Add(this.lblRightToLeft);
            this.panel2.Controls.Add(this.lblLeftToRight);
            this.panel2.Controls.Add(this.lblFontColor);
            this.panel2.Controls.Add(this.lblUnderline);
            this.panel2.Controls.Add(this.lblItalic);
            this.panel2.Controls.Add(this.lblBold);
            this.panel2.Controls.Add(this.lblJustify);
            this.panel2.Controls.Add(this.lblAlignL);
            this.panel2.Controls.Add(this.LblalignR);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 70);
            this.panel2.TabIndex = 52;
            // 
            // lblsuperscript
            // 
            this.lblsuperscript.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsuperscript.Image = global::irQm.Properties.Resources.superscript;
            this.lblsuperscript.Location = new System.Drawing.Point(452, 6);
            this.lblsuperscript.Name = "lblsuperscript";
            this.lblsuperscript.Size = new System.Drawing.Size(26, 26);
            this.lblsuperscript.TabIndex = 64;
            this.lblsuperscript.Click += new System.EventHandler(this.lblsuperscript_Click);
            // 
            // lblSubscript
            // 
            this.lblSubscript.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubscript.Image = global::irQm.Properties.Resources.subscript;
            this.lblSubscript.Location = new System.Drawing.Point(425, 6);
            this.lblSubscript.Name = "lblSubscript";
            this.lblSubscript.Size = new System.Drawing.Size(26, 26);
            this.lblSubscript.TabIndex = 63;
            this.lblSubscript.Click += new System.EventHandler(this.lblSubscript_Click);
            // 
            // lblPaste
            // 
            this.lblPaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPaste.Image = global::irQm.Properties.Resources.paste;
            this.lblPaste.Location = new System.Drawing.Point(91, 5);
            this.lblPaste.Name = "lblPaste";
            this.lblPaste.Size = new System.Drawing.Size(61, 58);
            this.lblPaste.TabIndex = 62;
            this.lblPaste.Click += new System.EventHandler(this.lblPaste_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCopy.Image = global::irQm.Properties.Resources.copy;
            this.lblCopy.Location = new System.Drawing.Point(3, 33);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(85, 28);
            this.lblCopy.TabIndex = 61;
            this.lblCopy.Click += new System.EventHandler(this.lblCopy_Click);
            // 
            // lblCut
            // 
            this.lblCut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCut.Image = global::irQm.Properties.Resources.cut;
            this.lblCut.Location = new System.Drawing.Point(3, 6);
            this.lblCut.Name = "lblCut";
            this.lblCut.Size = new System.Drawing.Size(85, 28);
            this.lblCut.TabIndex = 60;
            this.lblCut.Click += new System.EventHandler(this.lblCut_Click);
            // 
            // lblPictures
            // 
            this.lblPictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPictures.Image = global::irQm.Properties.Resources.pictures;
            this.lblPictures.Location = new System.Drawing.Point(158, 3);
            this.lblPictures.Name = "lblPictures";
            this.lblPictures.Size = new System.Drawing.Size(61, 58);
            this.lblPictures.TabIndex = 57;
            this.lblPictures.Click += new System.EventHandler(this.lblPictures_Click);
            // 
            // lblRightToLeft
            // 
            this.lblRightToLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRightToLeft.Image = global::irQm.Properties.Resources.right_to_left;
            this.lblRightToLeft.Location = new System.Drawing.Point(506, 8);
            this.lblRightToLeft.Name = "lblRightToLeft";
            this.lblRightToLeft.Size = new System.Drawing.Size(26, 26);
            this.lblRightToLeft.TabIndex = 56;
            // 
            // lblLeftToRight
            // 
            this.lblLeftToRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeftToRight.Image = global::irQm.Properties.Resources.left_to_right;
            this.lblLeftToRight.Location = new System.Drawing.Point(479, 7);
            this.lblLeftToRight.Name = "lblLeftToRight";
            this.lblLeftToRight.Size = new System.Drawing.Size(26, 26);
            this.lblLeftToRight.TabIndex = 55;
            // 
            // lblFontColor
            // 
            this.lblFontColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFontColor.Image = global::irQm.Properties.Resources.fontcolor;
            this.lblFontColor.Location = new System.Drawing.Point(397, 7);
            this.lblFontColor.Name = "lblFontColor";
            this.lblFontColor.Size = new System.Drawing.Size(26, 26);
            this.lblFontColor.TabIndex = 6;
            this.lblFontColor.Click += new System.EventHandler(this.lblFontColor_Click);
            // 
            // lblUnderline
            // 
            this.lblUnderline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnderline.Image = global::irQm.Properties.Resources.underline;
            this.lblUnderline.Location = new System.Drawing.Point(277, 8);
            this.lblUnderline.Name = "lblUnderline";
            this.lblUnderline.Size = new System.Drawing.Size(26, 26);
            this.lblUnderline.TabIndex = 5;
            this.lblUnderline.Click += new System.EventHandler(this.lblUnderline_Click);
            // 
            // lblItalic
            // 
            this.lblItalic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItalic.Image = global::irQm.Properties.Resources.italic;
            this.lblItalic.Location = new System.Drawing.Point(250, 8);
            this.lblItalic.Name = "lblItalic";
            this.lblItalic.Size = new System.Drawing.Size(26, 26);
            this.lblItalic.TabIndex = 4;
            this.lblItalic.Click += new System.EventHandler(this.lblItalic_Click);
            // 
            // lblBold
            // 
            this.lblBold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBold.Image = global::irQm.Properties.Resources.bold;
            this.lblBold.Location = new System.Drawing.Point(225, 8);
            this.lblBold.Name = "lblBold";
            this.lblBold.Size = new System.Drawing.Size(26, 26);
            this.lblBold.TabIndex = 3;
            this.lblBold.Click += new System.EventHandler(this.lblBold_Click);
            // 
            // lblJustify
            // 
            this.lblJustify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJustify.Image = global::irQm.Properties.Resources.justify;
            this.lblJustify.Location = new System.Drawing.Point(338, 8);
            this.lblJustify.Name = "lblJustify";
            this.lblJustify.Size = new System.Drawing.Size(26, 26);
            this.lblJustify.TabIndex = 2;
            this.lblJustify.Click += new System.EventHandler(this.lblJustify_Click);
            // 
            // lblAlignL
            // 
            this.lblAlignL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlignL.Image = global::irQm.Properties.Resources.alighn_left;
            this.lblAlignL.Location = new System.Drawing.Point(310, 8);
            this.lblAlignL.Name = "lblAlignL";
            this.lblAlignL.Size = new System.Drawing.Size(26, 26);
            this.lblAlignL.TabIndex = 1;
            this.lblAlignL.Click += new System.EventHandler(this.lblAlignL_Click);
            // 
            // LblalignR
            // 
            this.LblalignR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblalignR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblalignR.Image = global::irQm.Properties.Resources.align_right;
            this.LblalignR.Location = new System.Drawing.Point(368, 7);
            this.LblalignR.Name = "LblalignR";
            this.LblalignR.Size = new System.Drawing.Size(26, 26);
            this.LblalignR.TabIndex = 0;
            this.LblalignR.Click += new System.EventHandler(this.LblalignR_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 30);
            this.label5.TabIndex = 53;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblRedo
            // 
            this.lblRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblRedo.Image = global::irQm.Properties.Resources.redo;
            this.lblRedo.Location = new System.Drawing.Point(73, 55);
            this.lblRedo.Name = "lblRedo";
            this.lblRedo.Size = new System.Drawing.Size(26, 26);
            this.lblRedo.TabIndex = 65;
            this.lblRedo.Click += new System.EventHandler(this.lblRedo_Click);
            // 
            // lblUndo
            // 
            this.lblUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblUndo.Image = global::irQm.Properties.Resources.undo;
            this.lblUndo.Location = new System.Drawing.Point(45, 55);
            this.lblUndo.Name = "lblUndo";
            this.lblUndo.Size = new System.Drawing.Size(26, 26);
            this.lblUndo.TabIndex = 64;
            this.lblUndo.Click += new System.EventHandler(this.lblUndo_Click);
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblSave.Image = global::irQm.Properties.Resources.save1;
            this.lblSave.Location = new System.Drawing.Point(15, 55);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(26, 26);
            this.lblSave.TabIndex = 63;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTxtPic
            // 
            this.richTxtPic.BackColor = System.Drawing.SystemColors.Control;
            this.richTxtPic.Location = new System.Drawing.Point(398, 177);
            this.richTxtPic.Name = "richTxtPic";
            this.richTxtPic.Size = new System.Drawing.Size(184, 265);
            this.richTxtPic.TabIndex = 66;
            this.richTxtPic.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(306, 3);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(281, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "ورود  >  صفحه اصلی  >  ثبت سوال  >  ویرایش";
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTxtPic);
            this.Controls.Add(this.lblRedo);
            this.Controls.Add(this.lblUndo);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTxtEdit);
            this.Name = "FrmEdit";
            this.Text = "FrmEdit";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            this.Controls.SetChildIndex(this.richTxtEdit, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblSave, 0);
            this.Controls.SetChildIndex(this.lblUndo, 0);
            this.Controls.SetChildIndex(this.lblRedo, 0);
            this.Controls.SetChildIndex(this.richTxtPic, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private irQm.BaseCodes.CustomizedRichTextBox richTxtEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblalignR;
        private System.Windows.Forms.Label lblAlignL;
        private System.Windows.Forms.Label lblJustify;
        private System.Windows.Forms.Label lblUnderline;
        private System.Windows.Forms.Label lblItalic;
        private System.Windows.Forms.Label lblBold;
        private System.Windows.Forms.Label lblFontColor;
        private System.Windows.Forms.Label lblRightToLeft;
        private System.Windows.Forms.Label lblLeftToRight;
        private System.Windows.Forms.Label lblPictures;
        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblPaste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblUndo;
        private System.Windows.Forms.Label lblRedo;
        private System.Windows.Forms.Label lblSubscript;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblsuperscript;
        private System.Windows.Forms.RichTextBox richTxtPic;
        private System.Windows.Forms.Label label4;
    }
}