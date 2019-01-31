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
        private List<StringPair> _pairs;

        public List<StringPair> Pairs {
            get { _pairs.ForEach(p => { p.Value?.Trim(); });
                return _pairs; }
            set  { _pairs = value;Make(); }
        }


        public UCPuzzlePairs(List<StringPair> options)
        {
            InitializeComponent();
            fLPanel2.WrapContents = false;
            _pairs = options;
            Make();
        }

        public UCPuzzlePairs()
        {
            _pairs = new List<StringPair>() { new StringPair(1), new StringPair(2), new StringPair(3) };
            InitializeComponent();
            fLPanel2.WrapContents = false;
            Make();
        }

        private void Make()
        {
            fLPanel2.Controls.Clear();
            byte i = 1;
            foreach (StringPair o in _pairs)
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
            _pairs.Remove(ucpuzzleoption.Pair);
            fLPanel2.Controls.Remove(ucpuzzleoption);
            RefreshNumbers();
        }

        public void AddPair(StringPair pair)
        {
            pair.Number = Convert.ToByte(_pairs.Count + 1);
            _pairs.Add(pair);
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
