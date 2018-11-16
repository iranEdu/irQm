using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    public class Practical : IQuestion
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get; set; }
        [Required]
        public float Score { get; set; }
        public float GainedScore { get; set ; }
        public List<string> checkList { get; set; } = new List<string>();
        public List<string> Tags { get; set; } = new List<string>();
        [Required]
        public Lesson Lesson { get; set; }
        public string LessonName { get; set; }
        public User CreatedBy { get; set; }

    }
}
