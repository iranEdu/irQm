﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm
{
    public partial class UCTrueFalseAnswer : UserControl
    {
        public bool isTrue
        { get => chbTrue.Checked; set { chbTrue.Checked = value; } }

        public bool isFalse
        { get => chbFalse.Checked; set { chbFalse.Checked = value; } }

        public UCTrueFalseAnswer()
        {
            InitializeComponent();
        }
        public void New()
        {
            chbTrue.Checked = false;
            chbFalse.Checked = false;
         
        }
    }
}
