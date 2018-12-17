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
    public partial class UCOptionListPracical : UserControl
    {
        public List<Option> Options { get; private set; }

        public UCOptionListPracical(List<Option> options)
        {
            InitializeComponent();
            fLPanel.WrapContents = false;
            this.Options = options;
            Make();
        }

        public UCOptionListPracical()
        {
            this.Options = new List<Option>() { new Option(), new Option(), new Option() };
            InitializeComponent();
            fLPanel.WrapContents = false;
            Make();
        }
        private void Make()
        {
            //fLPanel.Controls.Clear();
            byte i = 1;
            foreach (Option o in Options)
            {
                o.number = i++;

                var oc = new UCOptionPractical(o);
                //oc.CheckedChanged += OptionItem_CheckedChanged;
                oc.Width = fLPanel.Width - 30;
                //oc.Anchor = AnchorStyles.Right | AnchorStyles.Left;



                oc.OptionRemoved += OptionRemoved;

                fLPanel.Controls.Add(oc);
            }



        }
        private void OptionRemoved(UCOptionPractical ucoptionpractical)
        {
            Options.Remove(ucoptionpractical.Option);
            fLPanel.Controls.Remove(ucoptionpractical);
            RefreshNumbers();
        }
        public void AddOption(Option option)
        {
            option.number = Convert.ToByte(Options.Count + 1);
            Options.Add(option);
            var oc = new UCOptionPractical(option);
            oc.Width = fLPanel.Width - 30;
            oc.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            oc.OptionRemoved += OptionRemoved;
            fLPanel.Controls.Add(oc);
        }

        private void RefreshNumbers()
        {
            byte i = 1;
            foreach (Control c in fLPanel.Controls)
            {
                ((UCOptionPractical)c).Number = i++;

            }
        }
    }
    }
