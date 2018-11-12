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
        public string LessonName { get ; set ; }
        public string Description { get; set; }
        internal List<TFQuestion> TFQuestions { get; set; }
        internal List<LongAnswer> LongAnswers { get; set; }
        internal List<ShortAnswer> ShortAnswers { get; set; }
        internal List<Practical> Practicals { get; set; }
        internal List<Puzzle> Puzzles { get; set; }
        internal List<MultiChoices> MultiChoicesQusestions { get; set; }
        //internal List<IQuestion> Questions { get; set; }

    }
}
