using irQm.BaseCodes;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace irQm.Forms
{
    public partial class Frmnewlesson : ExtendedForm
    {
        public Frmnewlesson()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (irQmDbContext db = new irQmDbContext())
                {
                    if (db.Lessons.Any(l => l.LessonName == txtLessonname.Text))
                    {
                        lblResult.Text = "این درس قبلا ثبت شده است";
                        lblResult.ForeColor = Color.Red;
                        return;
                    }
                    if (string.IsNullOrEmpty(txtLessonname.Text.Trim()))
                    {
                        lblResult.Text = "نام باید وارد شود";
                        lblResult.ForeColor = Color.Red;
                        return;
                    }

                    var lesson = new Lesson();
                    lesson.LessonName = txtLessonname.Text.Trim();
                    lesson.Description = txtDesc.Text.Trim();
                    db.Lessons.Add(lesson);
                    
                    db.SaveChanges();
                    lblResult.Text = "ثبت با موفقیت انجام شد";
                    lblResult.ForeColor = Color.Green;
                }
            }
            catch
            {
                lblResult.Text = "ایرادی در ثبت به وجود آمده است";
                lblResult.ForeColor = Color.Red;
            }
        }
    }
}
