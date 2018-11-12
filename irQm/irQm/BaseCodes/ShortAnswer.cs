using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    public class ShortAnswer : IQuestion,IEvaluable
    {
        [MaxLength(50)]
        public string Id { get; set; }
        [Required]
        public string Face { get; set ; }

        public float Score { get; set; }
        public float GainedScore { get; set; }
        public List<StringItem> Answer { get; set; }
        public ICollection<TagInQuestion<ShortAnswer>> Tags { get; set; }
        public string UserAnswer { get; set; }
        public Lesson Lesson { get ; set ; }
        public string LessonName { get; set; }

        public void Evaluate()
        {
                                                                                  
            for (int i = 0; i < Answer.Count; i++)
            {
                string str = Answer[i].Value;
                if (str.Trim().Replace(" ", "").Replace("‌", "").Replace('ي','ی').Replace( 'ك','ک').Replace('آ', 'ا') == UserAnswer.Replace(" ", "").Replace("‌", "").Replace('ي', 'ی').Replace('ك', 'ک').Replace('آ', 'ا'))
                {
                   
                    GainedScore = Score;
                    break;
                }
               
            }

            
            
        }
    }
}
