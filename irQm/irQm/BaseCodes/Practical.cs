using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    public class Practical : IQuestion
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get; set; }
        [Required]
        public float Score { get; set; }
        public float GainedScore { get; set ; }
        public List<StringItem> CheckList { get; set; }
        public ICollection<TagInQuestion<Practical>> Tags { get; set; }
        public byte[] Image { get ; set; }
        public DateTime RegisterTime { get; set; }
        public DateTime EditTime { get; set; }
        public Lesson Lesson { get; set; }
        [Required]
        public string LessonName { get; set; }
        public User CreatorUser { get; set; }
        public string CreatorUserId { get; set; }
        public bool JustInList { get; set; }

        public void DeleteFromDb()
        {
            using (var db = new irQmDbContext())
            {
                db.PracticalQuestions.Remove(this);
                db.SaveChanges();
            }
        }
        public IQuestion Clone()
        {
            var q = new Practical();
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
            q.CheckList = CheckList;
            return q;
        }
    }
}
