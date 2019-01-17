using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    public class Puzzle : IQuestion,IEvaluable
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get; set; }
        public byte[] Image { get; set; }

        [Required]
        public float Score { get; set; }

        public DateTime RegisterTime { get; set; }
        public DateTime EditTime { get; set; }

        public float GainedScore { get ; set ; }
        public ICollection<TagInQuestion<Puzzle>> Tags { get; set; }
        public List<StringPair> Pairs { get; set; }
        public List<StringItem> ExtraAnswers { get; set; }
        public List<StringPair> AnswerPairs { get; set; }

        public User CreatorUser { get; set; }
        public string CreatorUserId { get; set; }

        public Lesson Lesson { get; set; }
        [Required]
        public string LessonName { get; set; }

        public void Evaluate()
        {
            var count= AnswerPairs.Count(p=>Pairs.Contains(p));
            GainedScore=Score/count;
            
        }
    }
}
