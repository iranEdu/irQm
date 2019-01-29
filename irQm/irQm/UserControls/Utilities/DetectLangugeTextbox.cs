using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace irQm.UserControls.Utilities
{
    class DetectLangugeTextbox:TextBox
    {
        public bool IsEnglish(string inputstring)
        {
            Regex regex = new Regex(@"[A-Za-z0-9 .,-=+(){}\[\]\\]");
            MatchCollection matches = regex.Matches(inputstring);

            if (matches.Count.Equals(inputstring.Length))
            {
                this.TextAlign = HorizontalAlignment.Right;
                return true;
                
            }


            else
            {
                this.TextAlign = HorizontalAlignment.Left;
                return false;
            }

        }

    }
}
