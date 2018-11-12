using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    public class LongAnswer : IQuestion
    {
        [MaxLength(50)]
        public string Id { get; set; }
        [Required]
        public string Face { get; set; }
    
        public float Score { get; set; }
        public float GainedScore { get; set; }
        [Required]
        public string Answer { get;  set; }
        public ICollection<TagInQuestion<LongAnswer>> Tags { get; set; }
        public string LessonName { get; set; }
        public Lesson Lesson { get ; set; }
        //public Exam Exam { get; set ; }
        //List<TagInQuestionBase> IQuestion.Tags { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
