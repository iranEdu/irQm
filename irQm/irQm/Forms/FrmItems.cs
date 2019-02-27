using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.Forms
{
    public partial class FrmItems : Form
    {
        private List<string> _selectedList=new List<string>();
        private bool _multiple;
        Label lastSelected;
        public List<string> SelectedList { get => _selectedList; }
        public bool Multiple { get => _multiple; set => _multiple = value; }
        short selectedIndex =-1;
        public FrmItems(List<string> selection,string[] selected)

        {
            InitializeComponent();
            if (selected != null)
             _selectedList.AddRange(selected);
            //foreach (string s in selection )
            for (int i = 0; i < selection.Count; i++)
            {
                Label item = new Label();
                item.AutoSize = true;
                item.MinimumSize = new Size(Width- 25, 0);
                item.Cursor = Cursors.Hand;
                item.Text = selection[i];
                item.Click += Item_Click;
                item.Padding = new Padding(0,5,5,5);
                if(_selectedList.Contains(selection[i]))
                    item.BackColor = Color.LightBlue;
                else
                    item.BackColor = Color.Transparent;
                flowLayoutPanel1.Controls.Add(item);
            }

        }

        private void Item_Click(object sender, EventArgs e)
        {
            var item = ((Label)sender);
            if(_selectedList.Contains(item.Text))
            {
                _selectedList.Remove(item.Text);
                item.BackColor = Color.Transparent;
                if (lastSelected == item)
                    lastSelected = null;

            }
            else
            {
                _selectedList.Add(item.Text);
                item.BackColor = Color.LightSkyBlue;
                if(lastSelected!=null && !_multiple)
                    lastSelected.BackColor = Color.Transparent;
                lastSelected = item;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if(_selectedList.Count==0)
            {
                MessageBox.Show("گزینه‌‌ای انتخاب نشده است", "عدم انتخاب", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

       

        
    }
}

