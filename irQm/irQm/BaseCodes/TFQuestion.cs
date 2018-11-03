using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class TFQuestion : IQuestion,IEvaluable
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get ; set ; }
        public float Score { get; set; }
        public float gainedScore { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public TFOption TrueOption { get; set; }
        public TFOption FalseOption { get; set; }
        public Lesson Lesson { get; set; }
         
        public void Evaluate()
        {
            if ((TrueOption.IsTrue&&TrueOption.Answered) || (FalseOption.IsTrue&& FalseOption.Answered))
            {
                gainedScore = Score;
            }
        }
    }
}
