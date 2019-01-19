using irQm.BaseCodes;
using irQm.BaseCodes.Utilities;
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
    public partial class FrmInsertQuestion : MasterForm
    {
        
        public FrmInsertQuestion()
        {
            InitializeComponent();
            comboQuestionType.DataSource = BaseCodes.Utilities.Globals.QuestionTypes.Names;
            comboQuestionType.DisplayMember = "Name";
            comboQuestionType.ValueMember = "Value";
            comboQuestionType.SelectedIndexChanged += ComboQuestionType_SelectedIndexChanged;
            comboLesson.LoadItems();
          

        }

        private void ComboQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboQuestionType.SelectedValue)
            {
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.multiOption:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = true;
                    ucPuzzleAnswer1.Visible = false;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = false;
                    break;
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.shortAnswer:
                    ucShortAnswer1.Visible = true;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = false;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = false;
                    break;
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.practical:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = false;
                    ucPracticalAnswer1.Visible = true;
                    ucTrueFalseAnswer1.Visible = false;
                    break;
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.puzzle:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = true;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = false;
                    break;
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.trueOrFalse:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = false;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = true;
                    break;


            }
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
                    switch(comboQuestionType.SelectedValue)
                    {
                        case Globals.QuestionTypes.QType.multiOption:

                        RegisterMutiChoices(db);
                            break;
                        case Globals.QuestionTypes.QType.trueOrFalse:

                            break;
                    }
                }
                lblMessage.Text = "پرسش ثبت شد";
                lblMessage.ForeColor = Color.Green;
                
                rbFace.Rtf = "";
                tagsBox1.Text = "";
               
            }
            catch
            {
                lblMessage.Text = "مشکلی در عملیات پیش آمده است";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void RegisterMutiChoices(irQmDbContext db)
        {
            if (ucMultiOption1.Options.Count(o => o.IsTrue) < 1)
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


            var newOptions = new List<Option>();
            for (var i = 0; i < ucMultiOption1.Options.Count; i++)
            {
                newOptions.Add(new Option());
            }
            ucMultiOption1.New(newOptions);
        }
        private void RegisterTrueOrFalse(irQmDbContext db)
        {
            //if (ucTrueFalseAnswer1.Options.Count(o => o.IsTrue) < 1)
            //{
            //    lblMessage.Text = "گزینه یا گزینه های درست مشخص نشده است";
            //    lblMessage.ForeColor = Color.Red;

            //    return;
            //}

            //var q = new MultiChoices();
            //q.Id = Guid.NewGuid().ToString();
            //q.Face = rbFace.Rtf;

            //q.RegisterTime = DateTime.UtcNow;
            //var tagsInBox = tagsBox1.Tags;
            //var tags = db.Tags.Select(t => t.Value).ToArray();
            //foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
            //{
            //    var tag = new Tag();
            //    tag.Value = tg;
            //    db.Tags.Add(tag);

            //}
            //foreach (var t in tagsBox1.Tags)
            //{
            //    TagInQuestion<MultiChoices> tim = new TagInQuestion<MultiChoices>();
            //    tim.QuestionId = q.Id;
            //    tim.TagId = t;
            //    db.TagInMultichoices.Add(tim);
            //}
            //var options = ucMultiOption1.Options;

            //foreach (Option o in options)
            //{
            //    o.MultiChoicesId = q.Id;
            //    db.Option.Add(o);
            //}
            //q.LessonName = comboLesson.Text.Trim();
            //q.CreatorUserId = BaseCodes.Utilities.Globals.CurrentUser.UserId;

            //db.MultiChoicesQuestions.Add(q);

            //db.SaveChanges();


            //var newOptions = new List<Option>();
            //for (var i = 0; i < ucMultiOption1.Options.Count; i++)
            //{
            //    newOptions.Add(new Option());
            //}
            //ucMultiOption1.New(newOptions);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {


        }
    }
}
