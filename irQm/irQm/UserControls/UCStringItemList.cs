using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using irQm.BaseCodes;

namespace irQm.UserControls
{
    public partial class UCStringItemList : UserControl
    {
        private List<StringItem> _items;

        public List<StringItem> Items { get { _items.ForEach(i => { i.Value?.Trim();  });return _items.Where(i=>i!=null).ToList(); }
            set { _items = value; Make(); } }

        public UCStringItemList(List<StringItem> items)
        {
            InitializeComponent();
            fLPanel.WrapContents = false;
            _items = items;
            Make();
        }

        public UCStringItemList()
        {
            _items = new List<StringItem>() { new StringItem(1), new StringItem(2), new StringItem(3) };
            InitializeComponent();
            fLPanel.WrapContents = false;
            Make();
        }
        private void Make()
        {
            fLPanel.Controls.Clear();
            byte i = 1;
            foreach (StringItem o in _items)
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
            _items.Remove(ucoptionpractical.Item);
            fLPanel.Controls.Remove(ucoptionpractical);
            RefreshNumbers();
        }
        public void AddOption(StringItem option)
        {
            option.Number = Convert.ToByte(_items.Count + 1);
            _items.Add(option);
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
