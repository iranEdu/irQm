using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    public class Lesson
    {
        
        [Key]
        public string LessonName { get; set; }
        public string Description { get; set; }

        private ICollection<LongAnswer> _longAnswers { get; set; }
        private ICollection<MultiChoices> _multichice { get; set; }
        private ICollection<Practical> _practical { get; set; }
        private ICollection<ShortAnswer> _shortanswer { get; set; }
        private ICollection<Puzzle> _puzzle { get; set; }


    }
}
