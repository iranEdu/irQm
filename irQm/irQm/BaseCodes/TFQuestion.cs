using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public float Score { get; set; }
        public float GainedScore { get; set; }
        public ICollection<TagInQuestion<TFQuestion>> Tags { get; set; } 
        [Required]
        public TFOption TrueOption { get; set; }
        [Required]
        public TFOption FalseOption { get; set; }
        public Lesson Lesson { get; set; }
        public string LessonName { get; set; }

        public void Evaluate()
        {
            if ((TrueOption.IsTrue&&TrueOption.Answered) || (FalseOption.IsTrue&& FalseOption.Answered))
            {
                GainedScore = Score;
            }
        }
    }
}
