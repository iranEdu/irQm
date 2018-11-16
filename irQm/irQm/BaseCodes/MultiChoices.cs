using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace irQm.BaseCodes
{
    public class MultiChoices : IQuestion,IEvaluable
    {
        public List<Option> Options { get; set; }
        [MaxLength(50)]
        public string Id { get; private set; }
        public string Face { get; set; }
        [Required]
        public float Score { get; set; }
        public float GainedScore { get; set; }
        public ICollection<TagInQuestion<MultiChoices>> Tags { get; set; }
        bool multiSelection;
        public bool MultiSelections { get { return multiSelection; }set { multiSelection = value && Options.Count(o => o.IsTrue) > 1; } }
        public User CreatedBy { get; set; }

        [Required]
        public string LessonName { get; set; }
        public Lesson Lesson { get; set; }

        public void Mix() { }

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
