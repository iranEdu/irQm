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
    public partial class UCStringItemList : UserControl
    {
        public List<StringItem> Items { get; private set; }

        public UCStringItemList(List<StringItem> options)
        {
            InitializeComponent();
            fLPanel.WrapContents = false;
            this.Items = options;
            Make();
        }

        public UCStringItemList()
        {
            this.Items = new List<StringItem>() { new StringItem(), new StringItem(), new StringItem() };
            InitializeComponent();
            fLPanel.WrapContents = false;
            Make();
        }
        private void Make()
        {
            //fLPanel.Controls.Clear();
            byte i = 1;
            foreach ( StringItem o in Items)
            {
                o.Number = i++;

                var oc = new UCStringItem(o);
                //oc.CheckedChanged += OptionItem_CheckedChanged;
                oc.Width = fLPanel.Width - 30;
                //oc.Anchor = AnchorStyles.Right | AnchorStyles.Left;



                oc.ItemRemoved += OptionRemoved;

                fLPanel.Controls.Add(oc);
            }



        }
        private void OptionRemoved(UCStringItem ucoptionpractical)
        {
            Items.Remove(ucoptionpractical.Item);
            fLPanel.Controls.Remove(ucoptionpractical);
            RefreshNumbers();
        }
        public void AddOption(StringItem option)
        {
            option.Number = Convert.ToByte(Items.Count + 1);
            Items.Add(option);
            var oc = new UCStringItem(option);
            oc.Width = fLPanel.Width - 30;
            oc.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            oc.ItemRemoved += OptionRemoved;
            fLPanel.Controls.Add(oc);
        }

        private void RefreshNumbers()
        {
            byte i = 1;
            foreach (Control c in fLPanel.Controls)
            {
                ((UCStringItem)c).Number = i++;

            }
        }
    }
    }
