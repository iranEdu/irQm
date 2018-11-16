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
        public string Face { get; set; }
        [Required]
        public float Score { get; set; }
        public float gainedScore { get; set; }
        public float GainedScore { get ; set ; }
        public List<string> Tags { get ; set; }
        public Dictionary<string, string> Pairs { get; set; }
        public List<string> ExtraAnswers { get; set; }
        public Dictionary<string, string> AnswerPairs { get; set; }

        public User CreatedBy { get; set; }

        public Lesson Lesson { get; set; }
        [Required]
        public string LessonName { get; set; }

        public void Evaluate()
        {
            var count= AnswerPairs.Count(p=>Pairs.Contains(p));
            gainedScore=Score/count;
            
        }
    }
}
