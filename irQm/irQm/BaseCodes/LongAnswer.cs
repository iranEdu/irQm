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
        
        public float GainedScore { get ; set ; }
        public string Answer { get; private set; }
        public ICollection<TagInQuestion<LongAnswer>> Tags { get; set; }

        public Lesson Lesson { get ; set; }
        [Required]
        public string LessonName { get; set; }
        public User CreatedBy { get; set; }
    }
}
