using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace irQm.BaseCodes
{
    public class MultiChoices : IQuestion,IEvaluable
    {
        public List<Option> Options { get; set; }
        [MaxLength(50)]
        public string Id { get;set; }
        [Required]
        public string Face { get; set; } 
   
        public float Score { get; set; }
        
        public float GainedScore { get; set; }
        public ICollection<TagInQuestion<MultiChoices>> Tags { get; set; }
        private bool multiSelection;
        public bool MultiSelections {
            get { return multiSelection; }
        set { multiSelection = value && Options.Count(o => o.IsTrue) > 1; }
        }

        public Lesson Lesson { get; set; }
        public string LessonName { get; set; }

        public void Evaluate()
        {
            var c = Options.Count(o => o.IsTrue);
            

            if (c > 0)
            {
                var g = Score * ( Options.Count(o => o.IsTrue && o.Answered) - Options.Count(o=> o.Answered&& !o.IsTrue))/c;
                if (g < 0)
                    g = 0;
                GainedScore = g;
            }

        }
    }
}
