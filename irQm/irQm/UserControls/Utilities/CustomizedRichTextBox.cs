using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.BaseCodes
{
    
    class CustomizedRichTextBox : RichTextBox
    {
        
      

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Object data = Clipboard.GetDataObject();
           
            int offset = this.Rtf.IndexOf(@"\f0\fs17") + 8; // offset = 118;
            int len = this.Rtf.LastIndexOf(@"\par") - offset;
            if (this.Rtf.Substring(offset, len).Trim().Contains(@"{\pict\"))
                this.Undo();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
                if (Clipboard.ContainsImage())
                    e.Handled = true;
            base.OnKeyDown(e);

        }



    }


}
