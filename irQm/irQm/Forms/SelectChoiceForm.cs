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
    public partial class SelectChoiceForm : MasterForm
    {
        public List<string> selection;
        
        public SelectChoiceForm()

        {
            InitializeComponent();
            
            //foreach (string s in selection )
            for (int i = 0; i < selection.Count; i++)
            {
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Text = selection[i];
                flowLayoutPanel1.Controls.Add(label1);
            }
        }
    }
}

