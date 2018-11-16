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

        public ICollection<LongAnswer> LongAnswers { get; set; }
        public ICollection<MultiChoices> Multichices { get; set; }
        public ICollection<Practical> Practicals { get; set; }
        public ICollection<ShortAnswer> ShortAnswers { get; set; }
        public ICollection<Puzzle> Puzzles { get; set; }
        public ICollection<TFQuestion> TFQuestions { get; set; }



    }
}
