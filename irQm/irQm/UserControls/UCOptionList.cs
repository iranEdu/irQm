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
    public partial class UCOptionList : UserControl
    {
        byte checkedItems = 0;
        public List<Option> Options { get;private set; }
        public bool MultiSelect { get; set; }
        public UCOptionList(List<Option> options)
        {
            InitializeComponent();
            fLPanel.WrapContents = false;

            this.Options = options;
           
            Make();
        }
        public void New(List<Option> options)
        {
            this.Options = options;
            fLPanel.Controls.Clear();
            Make();
        }
        public UCOptionList()
        {
            this.Options = new List<Option>() { new Option(), new Option(), new Option(), new Option() };
            InitializeComponent();
            fLPanel.WrapContents = false;
            Make();
        }
        private void Make()
        {
            //fLPanel.Controls.Clear();
            byte i = 1;
            
            foreach(Option o in Options)
            {
                o.number = i++;
                
                var oc = new UCOption(o);
                oc.CheckedChanged += OptionItem_CheckedChanged;
                oc.Width = fLPanel.Width - 30;
                if (o.IsTrue)
                    checkedItems++;
                //oc.Anchor = AnchorStyles.Right | AnchorStyles.Left;



                oc.OptionRemoved += OptionRemoved;

                fLPanel.Controls.Add(oc);
            }
           

        }

        private void OptionItem_CheckedChanged(UCOption ucoption)
        {

            if (ucoption.Checked && !MultiSelect)
            {
                if(checkedItems == 1)
                {

                    foreach(UCOption o in fLPanel.Controls)
                    {
                        if(!o.Equals(ucoption))
                            o.Checked = false;
                        

                    }
                    
                }
                else if(checkedItems > 1)
                {
                    ucoption.Checked = false;
                    
                }
                
            }

            if (ucoption.Checked) checkedItems++; else checkedItems--;

            

        }

        private void OptionRemoved(UCOption ucoption)
        {
            Options.Remove(ucoption.Option);
            fLPanel.Controls.Remove(ucoption);
            RefreshNumbers();
        }

        public void AddOption(Option option)
        {
            option.number = Convert.ToByte(Options.Count+1);
            Options.Add(option);
            var oc = new UCOption(option);
            oc.Width = fLPanel.Width-30;
             oc.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            oc.OptionRemoved += OptionRemoved;
            fLPanel.Controls.Add(oc);
        }

        private void RefreshNumbers()
        {
            byte i = 1;
            foreach (Control c in fLPanel.Controls)
            {
                ((UCOption)c).Number = i++;
                
            }
        }
    }
}
