using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    class Exam
    {
        public string ExamName { get; set; }
        public bool Shuffle { get; private set; }
        public List<IQuestion> Questions { get; private set; }
        public string User { get; set; }
        public void Mix() { }
        [MaxLength(50)]
        public string Id { get;  set; }
   
    }
}
