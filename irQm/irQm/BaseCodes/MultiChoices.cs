using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
namespace irQm.BaseCodes
{
    public class MultiChoices : IQuestion,IEvaluable
    {
        public List<Option> Options { get; set; } = new List<Option>();
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get; set; }
        public byte[] Image { get; set; }

        [Required]
        public float Score { get; set; }
        public float GainedScore { get; set; }
        public ICollection<TagInQuestion<MultiChoices>> Tags { get; set; }
        bool multiSelection;
        public bool MultiSelections { get { return multiSelection; }set { multiSelection = value && Options.Count(o => o.IsTrue) > 1; } }
        public User CreatorUser { get; set; }
        public string CreatorUserId { get; set; }

        [Required]
        public string LessonName { get; set; }
        public Lesson Lesson { get; set; }
        public DateTime RegisterTime { get; set; }
        public DateTime EditTime { get; set; }
        public bool JustInList { get; set; }

        public void Mix() { }

        public void Evaluate()
        {
            var c = Options.Count(o => o.IsTrue);
            

            if (c > 0)
            {
                var g = Score * ( Options.Count(o => o.IsTrue && o.Answered) - Options.Count(o=> o.Answered&& !o.IsTrue))/c;
                if (g < 0)
                    g = 0;
                GainedScore = g;
            }

        }

        public void DeleteFromDb()
        {
            using (var db = new irQmDbContext())
            {
                db.MultiChoicesQuestions.Remove(this);
                db.SaveChanges();
            }
        }
        public IQuestion Clone()
        {
            var q = new MultiChoices();
            q.CreatorUser = CreatorUser;
            q.CreatorUserId = CreatorUserId;
            q.Face = Face;
            q.Id = Guid.NewGuid().ToString();
            q.Score = Score;
            q.JustInList = JustInList;
            q.Image = Image;
            q.GainedScore = GainedScore;
            q.RegisterTime = DateTime.UtcNow;
            q.Tags = Tags;
            q.Lesson = Lesson;
            q.LessonName = LessonName;
            q.Options = Options;
            q.MultiSelections = MultiSelections;
            return q;
        }
    }
}
