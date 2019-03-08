using irQm.BaseCodes;
using irQm.BaseCodes.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace irQm.UserControls.Forms
{
    public partial class EditQuestion : UserControl
    {
        Timer timer;
        IQuestion Question;
        public event EventHandler Saved;
        public event EventHandler Canceled;

        public EditQuestion(IQuestion question)
        {
            Question = question;
            InitializeComponent();
           
            comboQuestionType.DataSource = BaseCodes.Utilities.Globals.QuestionTypes.Names;
            comboQuestionType.DisplayMember = "Name";
            comboQuestionType.ValueMember = "Value";
            comboQuestionType.SelectedIndexChanged += ComboQuestionType_SelectedIndexChanged;
            comboLesson.LoadItems();

            rbFace.Rtf = question.Face;
            comboLesson.Text= question.LessonName;
            if(question is MultiChoices)
            {
                comboQuestionType.SelectedValue = Globals.QuestionTypes.QType.multiOption;
                var q = (MultiChoices)question;

                ucMultiOption1.New(q.Options,q.MultiSelections);
                tagsBox1.Tags = q.Tags.Select(t=>t.TagId).ToArray();
                               
            }
            else if (question is TFQuestion)
            {
                
                var q = (TFQuestion)question;
                ucTrueFalseAnswer1.New(q.TrueOption,q.FalseOption);
               
                tagsBox1.Tags = q.Tags.Select(t => t.TagId).ToArray();
                comboQuestionType.SelectedValue = Globals.QuestionTypes.QType.trueOrFalse;

            }
            
            else if (question is Puzzle)
            {

                var q = (Puzzle)question;
                ucPuzzleAnswer1.New( q.Pairs);

                tagsBox1.Tags = q.Tags.Select(t => t.TagId).ToArray();
                comboQuestionType.SelectedValue = Globals.QuestionTypes.QType.puzzle;

            }
            else if (question is ShortAnswer)
            {

                var q = (ShortAnswer)question;
                ucShortAnswer1.New(q.Answer);

                tagsBox1.Tags = q.Tags.Select(t => t.TagId).ToArray();
                comboQuestionType.SelectedValue = Globals.QuestionTypes.QType.shortAnswer;

            }
            else if (question is LongAnswer)
            {

                var q = (LongAnswer)question;
                ucLongAnswer1.Answer = q.Answer;

                tagsBox1.Tags = q.Tags.Select(t => t.TagId).ToArray();
                comboQuestionType.SelectedValue = Globals.QuestionTypes.QType.longAnswer;

            }
            else if (question is Practical)
            {

                var q = (Practical)question;
                ucPracticalAnswer1.New(q.CheckList);
                
                tagsBox1.Tags = q.Tags.Select(t => t.TagId).ToArray();
                comboQuestionType.SelectedValue = Globals.QuestionTypes.QType.practical;

            }
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
                case Globals.QuestionTypes.QType.shortAnswer:
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
                case Globals.QuestionTypes.QType.puzzle:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = true;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = false;
                    ucLongAnswer1.Visible = false;

                    break;
                case Globals.QuestionTypes.QType.trueOrFalse:
                    ucShortAnswer1.Visible = false;
                    ucMultiOption1.Visible = false;
                    ucPuzzleAnswer1.Visible = false;
                    ucPracticalAnswer1.Visible = false;
                    ucTrueFalseAnswer1.Visible = true;
                    ucLongAnswer1.Visible = false;

                    break;
                case Globals.QuestionTypes.QType.longAnswer:
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

        private void btnSave_Click(object sender, EventArgs e)
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
                    if (comboLesson.SelectedIndex < 0)
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
                        comboLesson.Items.Add(l.LessonName);
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
                   
                    lblMessage.Text = "پرسش ثبت شد";
                    lblMessage.ForeColor = Color.Green;
                    Saved?.Invoke(this, null);
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
            var saveInDb = false;

            if (ucShortAnswer1.StringList.Count==0)
            {
                lblMessage.Text = "جواب مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = (ShortAnswer)Question;

            if (db.ShortAnswerQustions.Contains(q))
            {
                saveInDb = true;
                db.ShortAnswerQustions.Remove(db.ShortAnswerQustions.First(qu => qu.Id == q.Id));
                db.SaveChanges();
            }
            
           
           
            var tagsInBox = tagsBox1.Tags;
            var tags = db.Tags.Select(t => t.Value).ToArray();
            //if (saveInDb)
            //{
            //    foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
            //    {
            //        var tag = new Tag();
            //        tag.Value = tg;
            //        db.Tags.Add(tag);

            //    }
            //    foreach (var t in tagsBox1.Tags)
            //    {
            //        TagInQuestion<ShortAnswer> tagInQuestion = new TagInQuestion<ShortAnswer>();
            //        tagInQuestion.QuestionId = q.Id;
            //        tagInQuestion.TagId = t;
            //        db.TagInShortAnswer.Add(tagInQuestion);
            //    }
            //}
            //else
            {
                var qtags = new List<TagInQuestion<ShortAnswer>>();
                foreach (var t in tagsInBox)
                {
                    TagInQuestion<ShortAnswer> tagInQuestion = new TagInQuestion<ShortAnswer>();
                    tagInQuestion.QuestionId = q.Id;
                    tagInQuestion.TagId = t;
                    qtags.Add(tagInQuestion);

                }
                q.Tags = qtags;
            }
            q.EditTime = DateTime.UtcNow;

            q.Answer = ucShortAnswer1.StringList;

            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;

            if (saveInDb)
            {
                foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
                {
                    var tag = new Tag();
                    tag.Value = tg;
                    db.Tags.Add(tag);

                }
                db.ShortAnswerQustions.Add(q);

                db.SaveChanges();
            }
            


            
          

            return true;
        }

        private bool RegisterPracticalQuestion(irQmDbContext db)
        {
            var saveInDb = false;
            var list = ucPracticalAnswer1.CheckList;
            if (list.Count == 0)
            {
                lblMessage.Text = "چک لیست خالی است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = (Practical)Question;
            if (db.PracticalQuestions.Contains(q))
            {
                saveInDb = true;
                db.PracticalQuestions.Remove(db.PracticalQuestions.First(qu => qu.Id == q.Id));
                db.SaveChanges();
            }
            
            q.Face = rbFace.Rtf;

            q.RegisterTime = DateTime.UtcNow;
            var tagsInBox = tagsBox1.Tags;
            var tags = db.Tags.Select(t => t.Value).ToArray();

            //if (saveInDb)
            //{
            //    foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
            //    {
            //        var tag = new Tag();
            //        tag.Value = tg;
            //        db.Tags.Add(tag);

            //    }



            //    foreach (var t in tagsBox1.Tags)
            //    {
            //        TagInQuestion<Practical> tagInQuestion = new TagInQuestion<Practical>();
            //        tagInQuestion.QuestionId = q.Id;
            //        tagInQuestion.TagId = t;
            //        db.TagInPractical.Add(tagInQuestion);
            //    }
            //}
            //else
            {
                var qtags = new List<TagInQuestion<Practical>>();
                foreach (var t in tagsInBox)
                {
                    TagInQuestion<Practical> tagInQuestion = new TagInQuestion<Practical>();
                    tagInQuestion.QuestionId = q.Id;
                    tagInQuestion.TagId = t;
                    qtags.Add(tagInQuestion);

                }
                q.Tags = qtags;
            }
            q.EditTime = DateTime.UtcNow;
            q.CheckList = list;

            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;
            if (saveInDb)
            {
                foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
                {
                    var tag = new Tag();
                    tag.Value = tg;
                    db.Tags.Add(tag);

                }
                db.PracticalQuestions.Add(q);

                db.SaveChanges();
            }
            
            return true;
        }

        private bool RegisterPuzzleQuestion(irQmDbContext db)
        {
            var saveInDb = false;
            var pairs = ucPuzzleAnswer1.StringPairs;
            if (pairs.Count==0)
            {
                lblMessage.Text = "جواب مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = (Puzzle)Question;
            if (db.PuzzleQuestions.Contains(q))
            {
                saveInDb = true;
                db.PuzzleQuestions.Remove(db.PuzzleQuestions.First(qu=>qu.Id==q.Id));
                db.SaveChanges();
            }
            
            q.Face = rbFace.Rtf;

            q.RegisterTime = DateTime.UtcNow;
            var tagsInBox = tagsBox1.Tags;
            var tags = db.Tags.Select(t => t.Value).ToArray();
            //if (saveInDb)
            //{
            //    foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
            //    {
            //        var tag = new Tag();
            //        tag.Value = tg;
            //        db.Tags.Add(tag);

            //    }

            //    foreach (var t in tagsBox1.Tags)
            //    {
            //        TagInQuestion<Puzzle> tagInQuestion = new TagInQuestion<Puzzle>();
            //        tagInQuestion.QuestionId = q.Id;
            //        tagInQuestion.TagId = t;
            //        db.TagInPuzzle.Add(tagInQuestion);
            //    }
            //}
            //else
            {
                var qtags = new List<TagInQuestion<Puzzle>>();
                foreach (var t in tagsInBox)
                {
                    TagInQuestion<Puzzle> tagInQuestion = new TagInQuestion<Puzzle>();
                    tagInQuestion.QuestionId = q.Id;
                    tagInQuestion.TagId = t;
                    qtags.Add(tagInQuestion);

                }
                q.Tags = qtags;
            }
            q.EditTime = DateTime.UtcNow;
            q.Pairs = pairs;

            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;
            if (saveInDb)
            {
                foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
                {
                    var tag = new Tag();
                    tag.Value = tg;
                    db.Tags.Add(tag);

                }
                db.PuzzleQuestions.Add(q);

                db.SaveChanges();
            }
            return true;
        }

        private bool RegisterLongAnswerQuestion(irQmDbContext db)
        {
            var saveInDb = false;
            if (string.IsNullOrEmpty(ucLongAnswer1.Answer))
            {
                lblMessage.Text = "جواب مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = (LongAnswer)Question;
            if (db.LongAnswerQuestions.Contains(q))
            {
                saveInDb = true;
                db.LongAnswerQuestions.Remove(db.LongAnswerQuestions.First(qu => qu.Id == q.Id));
                db.SaveChanges();
            }
            q.Face = rbFace.Rtf;

            q.RegisterTime = DateTime.UtcNow;
            var tagsInBox = tagsBox1.Tags;
            var tags = db.Tags.Select(t => t.Value).ToArray();
            //if (saveInDb)
            //{
            //    foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
            //    {
            //        var tag = new Tag();
            //        tag.Value = tg;
            //        db.Tags.Add(tag);

            //    }
            //    foreach (var t in tagsBox1.Tags)
            //    {
            //        TagInQuestion<LongAnswer> tagInQuestion = new TagInQuestion<LongAnswer>();
            //        tagInQuestion.QuestionId = q.Id;
            //        tagInQuestion.TagId = t;
            //        db.TagInLongAnswer.Add(tagInQuestion);
            //    }
            //}
            //else
            {
                var qtags = new List<TagInQuestion<LongAnswer>>();
                foreach (var t in tagsInBox)
                {
                    TagInQuestion<LongAnswer> tagInQuestion = new TagInQuestion<LongAnswer>();
                    tagInQuestion.QuestionId = q.Id;
                    tagInQuestion.TagId = t;
                    qtags.Add(tagInQuestion);

                }
                q.Tags = qtags;
            }
            q.EditTime = DateTime.UtcNow;
            q.Answer = ucLongAnswer1.Answer;

            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;
            if (saveInDb)
            {
                foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
                {
                    var tag = new Tag();
                    tag.Value = tg;
                    db.Tags.Add(tag);

                }
                db.LongAnswerQuestions.Add(q);

                db.SaveChanges();
            }
            
           

            return true;

        }

        private bool RegisterMultiChoices(irQmDbContext db)
        {
            var saveInDb = false;
            if (ucMultiOption1.Options.Count(o => o.IsTrue) < 1)
            {
                lblMessage.Text = "گزینه یا گزینه های درست مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = (MultiChoices)Question;
            if (db.MultiChoicesQuestions.Contains(q))
            {
                saveInDb = true;
                db.MultiChoicesQuestions.Remove(db.MultiChoicesQuestions.First(qu => qu.Id == q.Id));
                db.SaveChanges();
            }
           
            q.Face = rbFace.Rtf;

            q.RegisterTime = DateTime.UtcNow;
            var tagsInBox = tagsBox1.Tags;
            var tags = db.Tags.Select(t => t.Value).ToArray();
            //if (saveInDb)
            //{
            //    foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
            //    {
            //        var tag = new Tag();
            //        tag.Value = tg;
            //        db.Tags.Add(tag);

            //    }
            //    foreach (var t in tagsBox1.Tags)
            //    {
            //        TagInQuestion<MultiChoices> tim = new TagInQuestion<MultiChoices>();
            //        tim.QuestionId = q.Id;
            //        tim.TagId = t;
            //        db.TagInMultichoices.Add(tim);
            //    }
            //}
            //else 
            {
                var qtags = new List<TagInQuestion<MultiChoices>>();
                foreach (var t in tagsInBox)
                {
                    TagInQuestion<MultiChoices> tagInQuestion = new TagInQuestion<MultiChoices>();
                    tagInQuestion.QuestionId = q.Id;
                    tagInQuestion.TagId = t;
                    qtags.Add(tagInQuestion);

                }
                q.Tags = qtags;
            }
            q.EditTime = DateTime.UtcNow;
            var options = ucMultiOption1.Options;

            foreach (Option o in options)
            {
                o.MultiChoicesId = q.Id;
                db.Option.Add(o);
            }
            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = BaseCodes.Utilities.Globals.CurrentUser.UserId;

            if (saveInDb)
            {
                foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
                {
                    var tag = new Tag();
                    tag.Value = tg;
                    db.Tags.Add(tag);

                }
                db.MultiChoicesQuestions.Add(q);

                db.SaveChanges();
            }
            
            
            return true;

        }
        private bool RegisterTrueOrFalse(irQmDbContext db)
        {
            var saveInDb = false;
            if (!ucTrueFalseAnswer1.isTrue && !ucTrueFalseAnswer1.isFalse) 
            {
                lblMessage.Text = "گزینه درست مشخص نشده است";
                lblMessage.ForeColor = Color.Red;

                return false;
            }
            var q = (TFQuestion)Question;
            if (db.TFQuestions.Contains(q))
            {
                saveInDb = true;
                db.TFQuestions.Remove(db.TFQuestions.First(qu => qu.Id == q.Id));
                db.SaveChanges();
            }
           
            q.Face = rbFace.Rtf;

            q.RegisterTime = DateTime.UtcNow;
            var tagsInBox = tagsBox1.Tags;
            var tags = db.Tags.Select(t => t.Value).ToArray();

            //if (saveInDb)
            //{
            //    foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
            //    {
            //        var tag = new Tag();
            //        tag.Value = tg;
            //        db.Tags.Add(tag);

            //    }
            //    foreach (var t in tagsBox1.Tags)
            //    {
            //        TagInQuestion<TFQuestion> titf = new TagInQuestion<TFQuestion>();
            //        titf.QuestionId = q.Id;
            //        titf.TagId = t;
            //        db.TagInTfQuestion.Add(titf);
            //    }
            //}
            //else
            {
                var qtags = new List<TagInQuestion<TFQuestion>>();
                foreach (var t in tagsInBox)
                {
                    TagInQuestion<TFQuestion> tagInQuestion = new TagInQuestion<TFQuestion>();
                    tagInQuestion.QuestionId = q.Id;
                    tagInQuestion.TagId = t;
                    qtags.Add(tagInQuestion);

                }
                q.Tags = qtags;
            }
            q.EditTime = DateTime.UtcNow;
            //var to= new TFOption();
            
            //to.IsTrue = ucTrueFalseAnswer1.isTrue;
            //to.Id = Guid.NewGuid().ToString();
            //var fo = new TFOption();
            //fo.IsTrue = ucTrueFalseAnswer1.isFalse;
            //fo.Id = Guid.NewGuid().ToString();
            q.TrueOption = ucTrueFalseAnswer1.isTrue;
            q.FalseOption = ucTrueFalseAnswer1.isFalse;
            
            q.LessonName = comboLesson.Text.Trim();
            q.CreatorUserId = Globals.CurrentUser.UserId;

            if (saveInDb)
            {
                foreach (var tg in tagsInBox.Where(t => !(tags.Contains(t))))
                {
                    var tag = new Tag();
                    tag.Value = tg;
                    db.Tags.Add(tag);

                }
                db.TFQuestions.Add(q);

                db.SaveChanges();
            }
            
            return true;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            Canceled?.Invoke(this,null);
        }

        private void FrmInsertQuestion_Load(object sender, EventArgs e)
        {

        }
    }
}
