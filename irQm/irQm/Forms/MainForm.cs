using System;
using System.Windows.Forms;

namespace irQm.Forms
{
    public partial class MainForm : MasterForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        

       

        private void pbQuestionReg_Click(object sender, EventArgs e)
        {
            InsertQuestionForm insert = new InsertQuestionForm();
            insert.Show();
            this.Close();
        }

        private void pbNewLesson_Click(object sender, EventArgs e)
        {
            NewLessonForm nlesson = new NewLessonForm();
            nlesson.Show();
            this.Close();
        }


        private void pbExam_Click(object sender, EventArgs e)
        {
            Form fe = new ExamForm();
            fe.Show();
            this.Close();

        }

        private void pbExams_Click(object sender, EventArgs e)
        {
            Form fer = new ExamResultForm();
            fer.Show();
            this.Close();
        }
    }
}
