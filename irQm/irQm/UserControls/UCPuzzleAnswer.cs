using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm
{
    public partial class UCPuzzleAnswer : UserControl
    {
        private List<StringPair> _stringPairs;

        public List<StringPair> StringPairs { get => _stringPairs.Where(p => !(string.IsNullOrEmpty(p.Key) && string.IsNullOrEmpty(p.Value))).ToList(); set => _stringPairs = value; }

        public UCPuzzleAnswer()
        {
            InitializeComponent();
            StringPairs = ucOptionListpuzzle1.Options;

        }


        private void pbAdd_Click(object sender, EventArgs e)
        {
            ucOptionListpuzzle1.AddPair(new StringPair());
        }
        public void New()
        {
            List<StringPair> pairs = new List<StringPair>();
            for (byte i = 0; i < 3; i++)
            {
                var sp = new StringPair();
                sp.Id = Guid.NewGuid().ToString();

                pairs.Add(sp);
            }
            ucOptionListpuzzle1.Options = pairs;
        }
    }
}
