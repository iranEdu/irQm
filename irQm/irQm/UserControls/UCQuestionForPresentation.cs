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

namespace irQm
{
    public partial class UCQuestionForPresentation : UserControl
    {
       IQuestion Question;
       

        public UCQuestionForPresentation(IQuestion question)
        {
            InitializeComponent();
            Question = question;
            frtbFace.Rtf = question.Face;
            InitializeAnswerZone();
        }
       
        public UCQuestionForPresentation()
        {
            InitializeComponent();
            Question = new MultiChoices();
            
            InitializeAnswerZone();
        }
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value;
                
            }
        }

        private void InitializeAnswerZone()
        {
            UserControls.UCMultiOptionsForPresentation ucMultiOptionsForPresentation1;
            
            ucMultiOptionsForPresentation1 = new irQm.UserControls.UCMultiOptionsForPresentation((Question as MultiChoices).Options);

            // 
            // ucMultiOptionsForPresentation1
            // 
            ucMultiOptionsForPresentation1.Location = new Point(3, 77);
            ucMultiOptionsForPresentation1.Size = new Size(489, 42);
           ucMultiOptionsForPresentation1.TabIndex = 117;

           flowLayoutPanel1.Controls.Add(ucMultiOptionsForPresentation1);
        }

}
}
