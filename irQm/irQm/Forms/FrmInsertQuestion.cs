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
        Timer timer;
        
        public FrmInsertQuestion()
        {
            InitializeComponent();
            comboQuestionType.DataSource = BaseCodes.Utilities.Globals.QuestionTypes.Names;
            comboQuestionType.DisplayMember = "Name";
            comboQuestionType.ValueMember = "Value";
            comboQuestionType.SelectedIndexChanged += ComboQuestionType_SelectedIndexChanged;
            comboLesson.LoadItems();
            timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += Timer_Tick;

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
                    ucLongAnswer1.Visible = false;
                    break;
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.shortAnswer:
                    ucShortAnswer1.Visible = true;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = false;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = false;
                    ucLongAnswer1.Visible = false;

                    break;
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.practical:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = false;
                    ucPracticalAnswer1.Visible = true;
                    ucTrueFalseAnswer1.Visible = false;
                    ucLongAnswer1.Visible = false;

                    break;
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.puzzle:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = true;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = false;
                    ucLongAnswer1.Visible = false;

                    break;
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.trueOrFalse:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = false;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = true;
                    ucTrueFalseAnswer1.isTrue = true;
                    ucLongAnswer1.Visible = false;

                    break;
                case BaseCodes.Utilities.Globals.QuestionTypes.QType.longAnswer:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = false;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = false;
                    ucTrueFalseAnswer1.isTrue = true;
                    ucLongAnswer1.Visible = true;

                    break;


            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //try
            {
                bool success = false;
                using (irQmDbContext db = new irQmDbContext())
                {
                    if (string.IsNullOrWhiteSpace(rbFace.Text))
                    {
                        lblMessage.Text = "صورت سوال خالی است";
                        lblMessage.ForeColor = Color.Red;

                        return;
                    }
                    if (comboLesson.IsNew())
                    {
                        if (string.IsNullOrWhiteSpace(comboLesson.Text))
                        {
                            lblMessage.Text = "درس وارد نشده است";
                            lblMessage.ForeColor = Color.Red;

                            return;
                        }
                       var l = new Lesson();
                        l.LessonName = comboLesson.Text.Trim();
                        db.Lessons.Add(l);
                        comboLesson.LoadItems();
                    }
                    switch(comboQuestionType.SelectedValue)
                    {
                        case Globals.QuestionTypes.QType.multiOption:

                            success= RegisterMultiChoices(db);
                            break;
                        case Globals.QuestionTypes.QType.trueOrFalse:
                            success= RegisterTrueOrFalse(db);
                            break;
                        case Globals.QuestionTypes.QType.longAnswer:
                            success= RegisterLongAnswerQuestion(db);
                            break;
                        case Globals.QuestionTypes.QType.puzzle:
                            success= RegisterPuzzleQuestion(db);
                            break;
                        case Globals.QuestionTypes.QType.practical:
                            success = RegisterPracticalQuestion(db);
                            break;
                        case Globals.QuestionTypes.QType.shortAnswer:
                            success = RegisterShortAnswerQuestion(db);
                            break;
                    }
                }


                if (success)
                {
                    rbFace.Rtf = "";
                    tagsBox1.Text = "";
                    tagsBox1.UpdateTags();
                   
                    timer.Start();
                    lblMessage.Text = "پرسش ثبت شد";
                    lblMessage.ForeColor = Color.Green;
                }

            }
            //catch(Exception x)
            //{
            //    lblMessage.Text = "مشکلی در عملیات پیش آمده است"+x.ToString();
            //    lblMessage.ForeColor = Color.Red;
            //}
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            timer.Stop();
        }

        private bool RegisterShortAnswerQuestion(irQmDbContext db)
        {
            if (ucShortAnswer1.StringList.Count==0)
            {
                lblMessage.Text = "جواب مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = new ShortAnswer();
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
                TagInQuestion<ShortAnswer> tagInQuestion = new TagInQuestion<ShortAnswer>();
                tagInQuestion.QuestionId = q.Id;
                tagInQuestion.TagId = t;
                db.TagInShortAnswer.Add(tagInQuestion);
            }
            q.Answer = ucShortAnswer1.StringList;

            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;

            db.ShortAnswerQustions.Add(q);

            db.SaveChanges();


            ucShortAnswer1.New(new List<StringItem> {new StringItem(1),new StringItem(2),new StringItem(3) });
          

            return true;
        }

        private bool RegisterPracticalQuestion(irQmDbContext db)
        {
            var list = ucPracticalAnswer1.CheckList;
            if (list.Count == 0)
            {
                lblMessage.Text = "چک لیست خالی است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = new Practical();
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
                TagInQuestion<Practical> tagInQuestion = new TagInQuestion<Practical>();
                tagInQuestion.QuestionId = q.Id;
                tagInQuestion.TagId = t;
                db.TagInPractical.Add(tagInQuestion);
            }
            q.CheckList = list;

            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;

            db.PracticalQuestions.Add(q);

            db.SaveChanges();

            ucPracticalAnswer1.New(new List<StringItem>() { new StringItem(1),new StringItem(2),new StringItem(3) });
            return true;
        }

        private bool RegisterPuzzleQuestion(irQmDbContext db)
        {
            var pairs = ucPuzzleAnswer1.StringPairs;
            if (pairs.Count==0)
            {
                lblMessage.Text = "جواب مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = new Puzzle();
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
                TagInQuestion<Puzzle> tagInQuestion = new TagInQuestion<Puzzle>();
                tagInQuestion.QuestionId = q.Id;
                tagInQuestion.TagId = t;
                db.TagInPuzzle.Add(tagInQuestion);
            }
            q.Pairs = pairs;

            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;

            db.PuzzleQuestions.Add(q);

            db.SaveChanges();
            
            ucPuzzleAnswer1.New();
            return true;
        }

        private bool RegisterLongAnswerQuestion(irQmDbContext db)
        {
            if (string.IsNullOrEmpty(ucLongAnswer1.Answer))
            {
                lblMessage.Text = "جواب مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = new LongAnswer ();
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
                TagInQuestion<LongAnswer> tagInQuestion = new TagInQuestion<LongAnswer>();
                tagInQuestion.QuestionId = q.Id;
                tagInQuestion.TagId = t;
                db.TagInLongAnswer.Add(tagInQuestion);
            }
            q.Answer = ucLongAnswer1.Answer;

            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;

            db.LongAnswerQuestions.Add(q);

            db.SaveChanges();

           
            ucLongAnswer1.New();
           

            return true;

        }

        private bool RegisterMultiChoices(irQmDbContext db)
        {
            if (ucMultiOption1.Options.Count(o => o.IsTrue) < 1)
            {
                lblMessage.Text = "گزینه یا گزینه های درست مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
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
            return true;

        }
        private bool RegisterTrueOrFalse(irQmDbContext db)
        {
            if (!ucTrueFalseAnswer1.isTrue && !ucTrueFalseAnswer1.isFalse) 
            {
                lblMessage.Text = "گزینه درست مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = new TFQuestion();
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
                TagInQuestion<TFQuestion> titf = new TagInQuestion<TFQuestion>();
                titf.QuestionId = q.Id;
                titf.TagId = t;
                db.TagInTfQuestion.Add(titf);
            }
            var to= new TFOption();
            
            to.IsTrue = ucTrueFalseAnswer1.isTrue;
            to.Id = Guid.NewGuid().ToString();
            var fo = new TFOption();
            fo.IsTrue = ucTrueFalseAnswer1.isFalse;
            fo.Id = Guid.NewGuid().ToString();
            q.TrueOption = to;
            q.FalseOption = fo;
            
            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;
           
            db.TFQuestions.Add(q);

            db.SaveChanges();

           
            ucTrueFalseAnswer1.New();
            ucTrueFalseAnswer1.isTrue = true;
            return true;

        }
        private void btnNew_Click(object sender, EventArgs e)
        {


        }
    }
}
