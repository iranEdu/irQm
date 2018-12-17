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
    public partial class UCOptionListpuzzle : UserControl
    {
        
        public List<Option> Options { get; private set; }
        

        public UCOptionListpuzzle(List<Option> options)
        {
            InitializeComponent();
            fLPanel2.WrapContents = false;
            this.Options = options;
            Make();
        }

        public UCOptionListpuzzle()
        {
            this.Options = new List<Option>() {  new Option(), new Option(), new Option() , new Option()};
            InitializeComponent();
            fLPanel2.WrapContents = false;
            Make();
        }

        private void Make()
        {
            //fLPanel.Controls.Clear();
            byte i = 1;
            foreach (Option o in Options)
            {
                o.number = i++;

                var oc = new UCPuzzleOption(o);
              //  oc.CheckedChanged += OptionItem_CheckedChanged;
                oc.Width = fLPanel2.Width - 30;
                //oc.Anchor = AnchorStyles.Right | AnchorStyles.Left;



                oc.OptionRemoved += OptionRemoved;

                fLPanel2.Controls.Add(oc);
            }

        }
        private void OptionRemoved(UCPuzzleOption ucpuzzleoption)
        {
            Options.Remove(ucpuzzleoption.Option);
            fLPanel2.Controls.Remove(ucpuzzleoption);
            RefreshNumbers();
        }

        public void AddOption(Option option)
        {
            option.number = Convert.ToByte(Options.Count + 1);
            Options.Add(option);
            var oc = new UCPuzzleOption(option);
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
