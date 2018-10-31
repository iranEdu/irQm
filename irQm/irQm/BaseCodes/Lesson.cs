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

    }
}
