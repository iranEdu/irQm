using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.BaseCodes
{
    
    class RichTextClass:RichTextBox
    {
        
               
            private Boolean hasImage(object obj)
        {
            System.Windows.Forms.RichTextBox richTextBox = new System.Windows.Forms.RichTextBox();
            Object data = Clipboard.GetDataObject();
            Clipboard.SetDataObject(data);
            richTextBox.Paste();
            Clipboard.SetDataObject(data);
            int offset = richTextBox.Rtf.IndexOf(@"\f0\fs17") + 8; // offset = 118;
            int len = richTextBox.Rtf.LastIndexOf(@"\par") - offset;
            return richTextBox.Rtf.Substring(offset, len).Trim().Contains(@"{\pict\");
        }
        void PasteCommandHandler()
        {
            if (!Clipboard.ContainsImage())
            {
                this.Paste();
            }
        }




    }


}
