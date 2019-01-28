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

namespace irQm.UserControls
{
    public partial class UCPuzzlePairs : UserControl
    {
        private List<StringPair> _options;

        public List<StringPair> Options { get => _options; set  { _options = value;Make(); } }


        public UCPuzzlePairs(List<StringPair> options)
        {
            InitializeComponent();
            fLPanel2.WrapContents = false;
            _options = options;
            Make();
        }

        public UCPuzzlePairs()
        {
            _options = new List<StringPair>() { new StringPair(), new StringPair(), new StringPair() };
            InitializeComponent();
            fLPanel2.WrapContents = false;
            Make();
        }

        private void Make()
        {
            //fLPanel.Controls.Clear();
            byte i = 1;
            foreach (StringPair o in _options)
            {
                o.Number = i++;

                var oc = new UCPuzzleOption(o);
                //  oc.CheckedChanged += OptionItem_CheckedChanged;
                oc.Width = fLPanel2.Width - 30;
                //oc.Anchor = AnchorStyles.Right | AnchorStyles.Left;



                oc.PairRemoved += PairRemoved;

                fLPanel2.Controls.Add(oc);
            }

        }
        private void PairRemoved(UCPuzzleOption ucpuzzleoption)
        {
            _options.Remove(ucpuzzleoption.Pair);
            fLPanel2.Controls.Remove(ucpuzzleoption);
            RefreshNumbers();
        }

        public void AddPair(StringPair pair)
        {
            pair.Number = Convert.ToByte(_options.Count + 1);
            _options.Add(pair);
            var oc = new UCPuzzleOption(pair);
            oc.Width = fLPanel2.Width - 30;
            oc.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            // oc.OptionRemoved += OptionRemoved;
            fLPanel2.Controls.Add(oc);
        }



        private void RefreshNumbers()
        {
            byte i = 1;
            foreach (Control c in fLPanel2.Controls)
            {
                ((UCPuzzleOption)c).Number = i++;

            }
        }
       
    }
}
