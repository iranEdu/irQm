using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace irQm.BaseCodes
{
    [Serializable]
    public class LongAnswer : IQuestion
    {
        [NonSerialized]
        private User _creatorUser;
        [NonSerialized]
        private Lesson _lesson;

        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get; set; }

        [Required]
        public float Score { get; set; }

        public float GainedScore { get; set; }
        public string Answer { get; set; }
        public string UserAnswer { get; set; }
        public ICollection<TagInQuestion<LongAnswer>> Tags { get; set; }

        public Lesson Lesson { get => _lesson; set => _lesson = value; }
        [Required]
        public string LessonName { get; set; }
        public User CreatorUser { get => _creatorUser; set => _creatorUser = value; }
        public string CreatorUserId { get; set; }

        public byte[] Image { get; set; }
        public DateTime RegisterTime { get; set; }
        public DateTime EditTime { get; set; }
        public bool JustInList { get; set; }

        public IQuestion Clone()
        {
            var q = new LongAnswer();
            q.Answer = this.Answer;
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
            return q;
        }

        public void DeleteFromDb()
        {
            using (var db = new irQmDbContext())
            {
                db.LongAnswerQuestions.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
