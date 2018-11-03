 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class ShortAnswer : IQuestion
    {
        public string Face { get ; set; }
        public float Score { get; set; }
        public float gainedScore { get; set; }
        public string Answer { get; private set; }
        public List<string> Tags { get; set; } = new List<string>();
        public string UserAnswer { get; set; }
        public Lesson Lesson { get ; set ; }
         
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
