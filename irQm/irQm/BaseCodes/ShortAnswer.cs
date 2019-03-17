using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    [Serializable]
    public class ShortAnswer : IQuestion, IEvaluable
    {
        [NonSerialized]
        private User _creatorUser;
        [NonSerialized]
        private Lesson _lesson;

        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get; set; }
        public byte[] Image { get; set; }

        [Required]
        public float Score { get; set; }

        public float GainedScore { get; set; }
        public List<StringItem> Answer { get; set; }

        public ICollection<TagInQuestion<ShortAnswer>> Tags { get; set; }
        public string UserAnswer { get; set; }
        public DateTime RegisterTime { get; set; }
        public DateTime EditTime { get; set; }
        public User CreatorUser { get => _creatorUser; set => _creatorUser = value; }
        public string CreatorUserId { get; set; }

        public Lesson Lesson { get => _lesson; set => _lesson = value; }
        [Required]
        public string LessonName { get; set; }
        public bool JustInList { get; set; }

        public void DeleteFromDb()
        {
            using (var db = new irQmDbContext())
            {
                db.ShortAnswerQustions.Remove(this);
                db.SaveChanges();
            }
        }

        public void Evaluate()
        {

            for (int i = 0; i < Answer.Count; i++)
            {
                string str = Answer[i].Value;
                if (str.Trim().Replace(" ", "").Replace("‌", "").Replace('ي', 'ی').Replace('ك', 'ک').Replace('آ', 'ا') == UserAnswer.Replace(" ", "").Replace("‌", "").Replace('ي', 'ی').Replace('ك', 'ک').Replace('آ', 'ا'))
                {

                    GainedScore = Score;
                    break;
                }

            }



        }
        public IQuestion Clone()
        {
            var q = new ShortAnswer();
            q.CreatorUser = CreatorUser;
            q.CreatorUserId = CreatorUserId;
            q.Face = Face;
            q.Id = Guid.NewGuid().ToString();
            q.Score = Score;
            q.UserAnswer = UserAnswer;
            q.JustInList = JustInList;
            q.Image = Image;
            q.GainedScore = GainedScore;
            q.RegisterTime = DateTime.UtcNow;
            q.Tags = Tags;
            q.Lesson = Lesson;
            q.LessonName = LessonName;
            q.Answer = Answer;
            return q;
        }
    }
}
