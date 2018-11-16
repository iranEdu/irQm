using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    public class ShortAnswer : IQuestion,IEvaluable
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get; set ; }
        [Required]
        public float Score { get; set; }
        public float gainedScore { get; set; }
        public float GainedScore { get; set ; }
        public ICollection<StringItem> Answer { get; set; } = new List<StringItem>();
        public ICollection<TagInQuestion<LongAnswer>> Tags { get; set; }
        public string UserAnswer { get; set; }

        public User CreatedBy { get; set; }

        public Lesson Lesson { get ; set ; }
        [Required]
        public string LessonName { get; set; }

        public void Evaluate()
        {
                                                                                  
            for (int i = 0; i < Answer.Count; i++)
            {
                string str = Answer[i];
                if (str.Trim().Replace(" ", "").Replace("‌", "").Replace('ي','ی').Replace( 'ك','ک').Replace('آ', 'ا') == UserAnswer.Replace(" ", "").Replace("‌", "").Replace('ي', 'ی').Replace('ك', 'ک').Replace('آ', 'ا'))
                {
                   
                    gainedScore = Score;
                    break;
                }
               
            }

            
            
        }
    }
}
