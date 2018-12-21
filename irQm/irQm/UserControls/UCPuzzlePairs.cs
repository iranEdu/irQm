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
        
        public List<StringPair> Options { get; private set; }
        

        public UCPuzzlePairs(List<StringPair> options)
        {
            InitializeComponent();
            fLPanel2.WrapContents = false;
            this.Options = options;
            Make();
        }

        public UCPuzzlePairs()
        {
            this.Options = new List<StringPair>() {  new StringPair(), new StringPair(), new StringPair() , new StringPair()};
            InitializeComponent();
            fLPanel2.WrapContents = false;
            Make();
        }

        private void Make()
        {
            //fLPanel.Controls.Clear();
            byte i = 1;
            foreach (StringPair o in Options)
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
            Options.Remove(ucpuzzleoption.Pair);
            fLPanel2.Controls.Remove(ucpuzzleoption);
            RefreshNumbers();
        }

        public void AddPair(StringPair pair)
        {
            pair.Number = Convert.ToByte(Options.Count + 1);
            Options.Add(pair);
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
