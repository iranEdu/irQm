using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
   public class TFQuestion : IQuestion,IEvaluable
    {
        [MaxLength(50)]
        public string Id { get; set; }
        [Required] 
        public string Face { get ; set ; }

        public User CreatorUser { get; set; }
        public string CreatorUserId { get; set; }


        public DateTime RegisterTime { get; set; }
        public DateTime EditTime { get; set; }

        public float Score { get; set; }
        public float GainedScore { get; set; }
        public ICollection<TagInQuestion<TFQuestion>> Tags { get; set; } 
        [Required]
        public bool TrueOption { get; set; }
        [Required]
        public bool FalseOption { get; set; }

        public bool AnsweredTrueOption { get; set; }
        public bool AnsweredFalseOption { get; set; }

        public Lesson Lesson { get; set; }
        public string LessonName { get; set; }
        public byte[] Image { get ; set; }
        public bool JustInList { get; set; }

        public void DeleteFromDb()
        {
            using (var db = new irQmDbContext())
            {
                db.TFQuestions.Remove(this);
                db.SaveChanges();
            }

        }
        public IQuestion Clone()
        {
            var q = new TFQuestion();
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
            q.TrueOption = TrueOption;
            q.FalseOption = FalseOption;
           
            return q;
        }
        public void Evaluate()
        {
            if ((TrueOption&&TrueOption) || (FalseOption&& FalseOption))
            {
                GainedScore = Score;
            }
        }
    }
}
