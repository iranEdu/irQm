using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace irQm.UserControls.Utilities
{
    class AutoDirectionTextbox:TextBox
    {
       
        
        protected override void OnTextChanged(EventArgs e)
        {
  
            string basetxt = Regex.Replace(base.Text, "[0-9 ]", "");
       
                if (Regex.IsMatch(basetxt, "^[a-zA-Z].*$"))
                    base.RightToLeft = RightToLeft.No;
                else base.RightToLeft = RightToLeft.Yes;
            base.OnTextChanged(e);
        }

    }
}
