using irQm.UserControls.Forms;
using System;
using System.Windows.Forms;

namespace irQm.Forms
{
    public partial class FrmMain : MasterForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

       

        

       

        private void pbQuestionReg_Click(object sender, EventArgs e)
        {
            InsertQuestion insert = new InsertQuestion();
            insert.Show();
            this.Close();
        }

        private void pbNewLesson_Click(object sender, EventArgs e)
        {
            NewLesson nlesson = new NewLesson();
            nlesson.Show();
            this.Close();
        }


        private void pbExam_Click(object sender, EventArgs e)
        {
            var content = new Exam();
            content.Show();
            this.Close();

        }

        private void pbExams_Click(object sender, EventArgs e)
        {
            var content = new Exams();
            content.Show();
            this.Close();
        }

        private void pbQuestionbank_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            var f = new Bank();
            this.Controls.Add(f);
           // this.Close();
        }
    }
}
