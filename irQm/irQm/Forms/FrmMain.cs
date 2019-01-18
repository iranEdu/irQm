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
            FrmInsertQuestion insert = new FrmInsertQuestion();
            insert.Show();
            this.Close();
        }

        private void pbNewLesson_Click(object sender, EventArgs e)
        {
            Frmnewlesson nlesson = new Frmnewlesson();
            nlesson.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form fe = new FrmExam();
            fe.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form fer = new FrmExamResult();
            fer.Show();
        }
    }
}
