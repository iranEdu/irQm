using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.UserControls.Utilities
{
    public partial class InformaionBox : Component
    {
        public int Width
        {
            get { return flowLayoutPanel1.Width; }
            set
            {
                flowLayoutPanel1.Width = value;

            }
        }
        public Color BackColor
        {
            get { return flowLayoutPanel1.BackColor; }
            set
            {
                flowLayoutPanel1.BackColor = value;

            }
        }
        public InformaionBox(string[] information)
        {
            InitializeComponent();
            foreach(string s in information)
            {
                var lbl = new Label();
                lbl.Text = s;
                lbl.AutoSize = true;
                lbl.RightToLeft = RightToLeft.Yes;
                lbl.MaximumSize = new Size(Width, 0);
                lbl.BackColor = Color.Transparent;
                flowLayoutPanel1.Controls.Add(lbl);
                
            }
            var btn = new Button();
            btn.Dock = DockStyle.Fill;
            btn.Text = "بستن";
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public InformaionBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }

       
    }
}
