using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class Exam
    {
        
        public string ExamName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Shuffle { get; private set; }
        public List<IQuestion> Questions { get; private set; }
        public string User { get; set; }
        public void Mix() { }
        [MaxLength(50)]
        public string Id { get;  set; }
   
    }
}
