using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

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
        public string Answer { get;  set; }
        public ICollection<TagInQuestion<LongAnswer>> Tags { get; set; }

        public Lesson Lesson { get ; set; }
        [Required]
        public string LessonName { get; set; }
        public User CreatorUser { get; set; }
        public string CreatorUserId { get; set; }

        public byte[] Image { get ; set; }
        public DateTime RegisterTime { get; set; }
        public DateTime EditTime { get; set; }
    }
}
