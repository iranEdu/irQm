using irQm.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irQm.UserControls.Utilities
{
   public  class LessonsComboBox:UserControl
    {
        private TextBox txtLesson;
        private Button btnSelect;
        List<string> items = new List<string>();
        public bool IsNew() { return !items.Contains(txtLesson.Text); }
        public override string Text { get => txtLesson.Text; set => txtLesson.Text = value; }
        
        public LessonsComboBox():base()
        {
            InitializeComponent();
            txtLesson.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtLesson.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        public void LoadItems()
        {
            var src = new AutoCompleteStringCollection();
            items.Clear();
            using (BaseCodes.irQmDbContext db = new BaseCodes.irQmDbContext())
            {
                foreach (var l in db.Lessons.OrderBy(l => l.LessonName))
                {
                    items.Add(l.LessonName);


                }
                
            }
            src.AddRange(items.ToArray());
            txtLesson.AutoCompleteCustomSource = src;
        }

        private void InitializeComponent()
        {
            this.txtLesson = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLesson
            // 
            this.txtLesson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLesson.Location = new System.Drawing.Point(50, 0);
            this.txtLesson.Name = "txtLesson";
            this.txtLesson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLesson.Size = new System.Drawing.Size(126, 20);
            this.txtLesson.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(0, -2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "انتخاب";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // LessonsComboBox
            // 
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtLesson);
            this.Name = "LessonsComboBox";
            this.Size = new System.Drawing.Size(176, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FrmItems itemsfrm = new FrmItems(items, null);
            if (itemsfrm.ShowDialog() == DialogResult.OK)
                txtLesson.Text = itemsfrm.SelectedList[0];
        }

    }
}
