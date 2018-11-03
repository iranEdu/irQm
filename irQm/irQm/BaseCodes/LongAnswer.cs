using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class LongAnswer : IQuestion
    {
        public string Face { get; set ; }
        public float Score { get ; set ; }
        public float gainedScore { get; set ; }
        public string Answer { get; private set; }
        public List<string> Tags { get; set; } = new List<string>();
        public Lesson Lesson { get ; set; } 
        [MaxLength(50)]
        public string ID{get;set;}

    }
}
