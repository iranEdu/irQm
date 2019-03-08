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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<StringPair> StringPairs { get =>_stringPairs.Where(p => !(string.IsNullOrWhiteSpace(p.Value) && string.IsNullOrWhiteSpace(p.Key))).ToList(); set { _stringPairs = value; } }

        public UCPuzzleAnswer()
        {
            InitializeComponent();
            StringPairs = ucOptionListpuzzle1.Pairs;

        }
        public UCPuzzleAnswer(List<StringPair> pairs)
        {
            InitializeComponent();
            StringPairs = pairs;
            

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
            ucOptionListpuzzle1.Pairs = pairs;
        }
        public void New(List<StringPair> pairs)
        {


            _stringPairs = pairs;
            ucOptionListpuzzle1.Pairs = pairs;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
