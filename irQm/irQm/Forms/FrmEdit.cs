using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace irQm.Forms
{
    public partial class FrmEdit : Form
    {
        public FrmEdit()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBold_Click(object sender, EventArgs e)
        {
            richTxtEdit.SelectionFont = new Font(richTxtEdit.Font, FontStyle.Bold);
        }

        private void LblalignR_Click(object sender, EventArgs e)
        {
         
            richTxtEdit.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void lblJustify_Click(object sender, EventArgs e)
        {
            
            richTxtEdit.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void lblAlignL_Click(object sender, EventArgs e)
        {
            
            richTxtEdit.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void lblFontColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTxtEdit.SelectionColor = colorDialog1.Color;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblItalic_Click(object sender, EventArgs e)
        {
            richTxtEdit.SelectionFont = new Font(richTxtEdit.Font, FontStyle.Italic);
        }

        private void lblUnderline_Click(object sender, EventArgs e)
        {
            richTxtEdit.SelectionFont = new Font(richTxtEdit.Font, FontStyle.Underline);
        }

        private void lblCut_Click(object sender, EventArgs e)
        {
               
               
            richTxtEdit.Cut();

        }
       void CutAction(object sender, EventArgs e)
        {
            richTxtEdit.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
           
            richTxtEdit.Copy();
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTxtEdit.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();

            }
        } 

        private void lblCopy_Click(object sender, EventArgs e)
        {
            
            richTxtEdit.Copy();
        }

        private void lblPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTxtEdit.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();

            }

        }

        private void richTxtEdit_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void lblPictures_Click(object sender, EventArgs e)
        {
            
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                int imgheight = img.Height;
                int imgwidth = img.Width;


                if (img.Width > 500)
                {
                    
                   
                    int finalheight = (int)(500.0/imgwidth*imgheight);
                    
                     img = new Bitmap(img, new Size(500,finalheight));
                    
                }
                
                
                 imagBox.Image = img;
                imagBox.Height = img.Height;
            }
                      


        }

        private void lblSubscript_Click(object sender, EventArgs e)
        {
            
        richTxtEdit.SelectionCharOffset = -7;
         
        }

        private void lblsuperscript_Click(object sender, EventArgs e)
        {
            richTxtEdit.SelectionCharOffset = 7;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTxtEdit_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void combofontsize_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void combofont_DropDownStyleChanged(object sender, ToolStripItemClickedEventArgs e)
        {
            if (richTxtEdit.SelectionFont == null)
            {
                richTxtEdit.SelectionFont = new Font(e.ClickedItem.Text, richTxtEdit.Font.Size);
            }
            richTxtEdit.SelectionFont = new Font(e.ClickedItem.Text, richTxtEdit.SelectionFont.Size);
        }

        private void combofontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combofont_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblUndo_Click(object sender, EventArgs e)
        {
            if (richTxtEdit.CanUndo)
            {
                richTxtEdit.Undo();
                
            }
        }

        private void lblRedo_Click(object sender, EventArgs e)
        {
            if (richTxtEdit.CanRedo == true)
            {
                if (richTxtEdit.RedoActionName != "Delete")
                    richTxtEdit.Redo();
            }
        }

        private void lblRightToLeft_Click(object sender, EventArgs e)
        {
            richTxtEdit.RightToLeft = RightToLeft.Yes;
            
        }

        private void lblLeftToRight_Click(object sender, EventArgs e)
        {
            richTxtEdit.RightToLeft = RightToLeft.No;
        }

        private void imagBox_MouseDown(object sender, MouseEventArgs e)
        {   
            picdeletimg.Visible = true;
          
         
            picdeletimg.Top =imagBox.Top;
            picdeletimg.Left = imagBox.Width-picdeletimg.Width;
        }

        private void picdeletimg_Click(object sender, EventArgs e)
        {
            imagBox.Image = null;
            picdeletimg.Visible = false;
        }
    }
}
