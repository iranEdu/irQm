using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    public class LongAnswer : IQuestion
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get ; set ; }
        [Required]
        public float Score { get ; set; }
        public float gainedScore { get; set; }
        public float GainedScore { get ; set ; }
        public string Answer { get; private set; }
        public List<string> Tags { get; set; } = new List<string>();
        
        public Lesson Lesson { get ; set; }
        [Required]
        public string LessonName { get; set; }
        public User CreatedBy { get; set; }
    }
}
