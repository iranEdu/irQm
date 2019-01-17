using irQm.BaseCodes;
using irQm.UserControls.Utilities;
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
    public partial class FrmInsertQuestion : ExtendedForm
    {
       
        public FrmInsertQuestion()
        {
            InitializeComponent();
            comboQuestionType.DataSource = BaseCodes.Utilities.Globals.QuestionTypes.Names;
            comboQuestionType.DisplayMember = "Name";
            comboQuestionType.ValueMember = "Value";
            comboLesson.LoadItems();
          

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (irQmDbContext db = new irQmDbContext())
                {
                    if (comboLesson.SelectedIndex < 0)
                    {
                        if (string.IsNullOrEmpty(comboLesson.Text.Trim()))
                        {
                            lblMessage.Text = "درس وارد نشده است";
                            lblMessage.ForeColor = Color.Red;

                            return;
                        }
                        var l = new Lesson();
                        l.LessonName = comboLesson.Text.Trim();
                        db.Lessons.Add(l);
                        comboLesson.Items.Add(l.LessonName);
                    }
                    if (ucMultiOption1.Visible)
                    {
                       if(ucMultiOption1.Options.Count(o=>o.IsTrue)<1)
                        {
                            lblMessage.Text = "گزینه یا گزینه های درست مشخص نشده است";
                            lblMessage.ForeColor = Color.Red;
                            
                            return;
                        }

                        var q = new MultiChoices();
                        q.Id = Guid.NewGuid().ToString();
                        q.Face = rbFace.Rtf;

                        q.RegisterTime = DateTime.UtcNow;
                        var tagsInBox = tagsBox1.Tags;
                        var tags = db.Tags.Select(t => t.Value).ToArray();
                        foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
                        {
                            var tag = new Tag();
                            tag.Value = tg;
                            db.Tags.Add(tag);

                        }
                        foreach (var t in tagsBox1.Tags)
                        {
                            TagInQuestion<MultiChoices> tim = new TagInQuestion<MultiChoices>();
                            tim.QuestionId = q.Id;
                            tim.TagId = t;
                            db.TagInMultichoices.Add(tim);
                        }
                        var options = ucMultiOption1.Options;

                        foreach (Option o in options)
                        {
                            o.MultiChoicesId = q.Id;
                            db.Option.Add(o);
                        }
                        q.LessonName = comboLesson.Text.Trim();
                        q.CreatorUserId = BaseCodes.Utilities.Globals.CurrentUser.UserId;

                        db.MultiChoicesQuestions.Add(q);

                        db.SaveChanges();



                    }
                }
                lblMessage.Text = "پرسش ثبت شد";
                lblMessage.ForeColor = Color.Green;
                var newOptions = new List<Option>();
                rbFace.Rtf = "";
                tagsBox1.Text = "";
                for (var i = 0; i < ucMultiOption1.Options.Count; i++)
                {
                    newOptions.Add(new Option());
                }
                ucMultiOption1.New(newOptions);
            }
            catch
            {
                lblMessage.Text = "مشکلی در عملیات پیش آمده است";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
