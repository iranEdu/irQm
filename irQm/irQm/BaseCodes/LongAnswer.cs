using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class LongAnswer : IQuestion
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        public float Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float gainedScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Answer { get; private set; }
        public List<string> Tags { get; set; } = new List<string>();
        [Required]
        public Lesson Lesson { get ; set; } 
    }
}
