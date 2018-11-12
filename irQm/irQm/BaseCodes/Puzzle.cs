using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    public class Puzzle : IQuestion,IEvaluable
    {
        [MaxLength(50)]
        public string id { get; set; }
        [Required]
        public string Face { get; set; }

        public float Score { get; set; }
        public float GainedScore { get; set; }
        public ICollection<TagInQuestion<Puzzle>> Tags { get ; set; }
        public List< StringPair> Pairs { get; set; }
        public List<StringItem> ExtraAnswers { get; set; }
        public List<StringPair> AnswerPairs { get; set; }
        public Lesson Lesson { get; set; }
        public string LessonName { get; set; }

        public void Evaluate()
        {
            var count= AnswerPairs.Count(p=>Pairs.Contains(p));
            GainedScore=Score/count;
            
        }
    }
}
