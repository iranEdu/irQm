using irQm.BaseCodes;
using irQm.UserControls.Forms;
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
    public partial class FrmQuestion : Form
    {
        IQuestion question;
        private bool _isEdited;
        bool openInEditMode;
        public bool IsEdited { get => _isEdited; set => _isEdited = value; }
        public FrmQuestion(IQuestion q, bool editable,bool openInEditMode)
        {
            this.openInEditMode = openInEditMode;
            InitializeComponent();
            this.ShowInTaskbar = false;
            question = q;
            if (!editable)
                btnEdit.Visible = false;

            if (openInEditMode)
            {
                showPanel.Visible = false;
                var editPanel = new EditQuestion(question);
                editPanel.Dock = DockStyle.Fill;
                Controls.Add(editPanel);
                editPanel.Saved += EditPanel_Saved;
                editPanel.Canceled += EditPanel_Canceled;
            }
            else
                init();

        }

        private void init()
        {
            if (question is MultiChoices)
                ucQuestionForPresentation1.Initialize((MultiChoices)question, false, true);
            else if (question is TFQuestion)
                ucQuestionForPresentation1.Initialize((TFQuestion)question, false, true);
            else if (question is Puzzle)
                ucQuestionForPresentation1.Initialize((Puzzle)question, false, true);
            else if (question is ShortAnswer)
                ucQuestionForPresentation1.Initialize((ShortAnswer)question, false, true);
            else if (question is LongAnswer)
                ucQuestionForPresentation1.Initialize((LongAnswer)question, false, true);
            else if (question is Practical)
                ucQuestionForPresentation1.Initialize((Practical)question, false, true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            showPanel.Visible = false;
            var editPanel = new EditQuestion(question);
            editPanel.Dock = DockStyle.Fill;
            Controls.Add(editPanel);
            editPanel.Saved += EditPanel_Saved;
            editPanel.Canceled += EditPanel_Canceled;


        }

        private void EditPanel_Canceled(object sender, EventArgs e)
        {
            if (openInEditMode)
            {
                Close();
            }
            else
            {
                ((EditQuestion)sender).Dispose();
                showPanel.Visible = true;
            }
        }

        private void EditPanel_Saved(object sender, EventArgs e)
        {
            _isEdited = true;
            if (openInEditMode)
            {
                Close();
            }
            else
            {
                init();
                ((EditQuestion)sender).Dispose();
                showPanel.Visible = true;
            }
            

        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {

        }

        private void ucQuestionForPresentation1_Load(object sender, EventArgs e)
        {

        }
    }
}
