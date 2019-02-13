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
            this.components = new System.ComponentModel.Container();
            this.richTxtEdit = new irQm.BaseCodes.CustomizedRichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.نسخهبرداریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انتقالToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.چسباندنPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label4 = new System.Windows.Forms.Label();
            this.imagBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxtEdit
            // 
            this.richTxtEdit.ContextMenuStrip = this.contextMenuStrip1;
            this.richTxtEdit.Location = new System.Drawing.Point(7, 119);
            this.richTxtEdit.Name = "richTxtEdit";
            this.richTxtEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTxtEdit.Size = new System.Drawing.Size(543, 169);
            this.richTxtEdit.TabIndex = 51;
            this.richTxtEdit.Text = "";
            this.richTxtEdit.SelectionChanged += new System.EventHandler(this.richTxtEdit_SelectionChanged);
            this.richTxtEdit.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTxtEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTxtEdit_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.نسخهبرداریToolStripMenuItem,
            this.انتقالToolStripMenuItem,
            this.چسباندنPasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 70);
            // 
            // نسخهبرداریToolStripMenuItem
            // 
            this.نسخهبرداریToolStripMenuItem.Name = "نسخهبرداریToolStripMenuItem";
            this.نسخهبرداریToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.نسخهبرداریToolStripMenuItem.Text = "نسخه برداری (Copy)";
            this.نسخهبرداریToolStripMenuItem.Click += new System.EventHandler(this.CopyAction);
            // 
            // انتقالToolStripMenuItem
            // 
            this.انتقالToolStripMenuItem.Name = "انتقالToolStripMenuItem";
            this.انتقالToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.انتقالToolStripMenuItem.Text = "انتقال (Cut)";
            this.انتقالToolStripMenuItem.Click += new System.EventHandler(this.CutAction);
            // 
            // چسباندنPasteToolStripMenuItem
            // 
            this.چسباندنPasteToolStripMenuItem.Name = "چسباندنPasteToolStripMenuItem";
            this.چسباندنPasteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.چسباندنPasteToolStripMenuItem.Text = "چسباندن (Paste)";
            this.چسباندنPasteToolStripMenuItem.Click += new System.EventHandler(this.PasteAction);
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
            this.panel2.Location = new System.Drawing.Point(9, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 70);
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
            this.lblRightToLeft.Click += new System.EventHandler(this.lblRightToLeft_Click);
            // 
            // lblLeftToRight
            // 
            this.lblLeftToRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLeftToRight.Image = global::irQm.Properties.Resources.left_to_right;
            this.lblLeftToRight.Location = new System.Drawing.Point(479, 7);
            this.lblLeftToRight.Name = "lblLeftToRight";
            this.lblLeftToRight.Size = new System.Drawing.Size(26, 26);
            this.lblLeftToRight.TabIndex = 55;
            this.lblLeftToRight.Click += new System.EventHandler(this.lblLeftToRight_Click);
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
            this.LblalignR.Location = new System.Drawing.Point(341, 7);
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
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(543, 30);
            this.label5.TabIndex = 53;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblRedo
            // 
            this.lblRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblRedo.Image = global::irQm.Properties.Resources.redo;
            this.lblRedo.Location = new System.Drawing.Point(61, 13);
            this.lblRedo.Name = "lblRedo";
            this.lblRedo.Size = new System.Drawing.Size(26, 26);
            this.lblRedo.TabIndex = 65;
            this.lblRedo.Click += new System.EventHandler(this.lblRedo_Click);
            // 
            // lblUndo
            // 
            this.lblUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblUndo.Image = global::irQm.Properties.Resources.undo;
            this.lblUndo.Location = new System.Drawing.Point(33, 13);
            this.lblUndo.Name = "lblUndo";
            this.lblUndo.Size = new System.Drawing.Size(26, 26);
            this.lblUndo.TabIndex = 64;
            this.lblUndo.Click += new System.EventHandler(this.lblUndo_Click);
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lblSave.Image = global::irQm.Properties.Resources.save1;
            this.lblSave.Location = new System.Drawing.Point(3, 13);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(26, 26);
            this.lblSave.TabIndex = 63;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            // imagBox
            // 
            this.imagBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagBox.Location = new System.Drawing.Point(7, 294);
            this.imagBox.Name = "imagBox";
            this.imagBox.Size = new System.Drawing.Size(543, 50);
            this.imagBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagBox.TabIndex = 139;
            this.imagBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imagBox);
            this.panel1.Controls.Add(this.lblRedo);
            this.panel1.Controls.Add(this.lblUndo);
            this.panel1.Controls.Add(this.lblSave);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.richTxtEdit);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 407);
            this.panel1.TabIndex = 140;
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "FrmEdit";
            this.Text = "FrmEdit";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagBox)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem نسخهبرداریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انتقالToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem چسباندنPasteToolStripMenuItem;
        private System.Windows.Forms.PictureBox imagBox;
        private System.Windows.Forms.Panel panel1;
    }
}