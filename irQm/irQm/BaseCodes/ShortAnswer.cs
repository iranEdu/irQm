using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    public class ShortAnswer : IQuestion,IEvaluable
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get; set ; }
        public byte[] Image { get; set; }

        [Required]
        public float Score { get; set; }
        
        public float GainedScore { get; set ; }
        public List<StringItem> Answer { get; set; }

        public ICollection<TagInQuestion<ShortAnswer>> Tags { get; set; }
        public string UserAnswer { get; set; }
        public DateTime RegisterTime { get; set; }
        public DateTime EditTime { get; set; }
        public User CreatorUser { get; set; }
        public string CreatorUserId { get; set; }

        public Lesson Lesson { get ; set ; }
        [Required]
        public string LessonName { get; set; }
        public bool JustInList { get; set; }

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
