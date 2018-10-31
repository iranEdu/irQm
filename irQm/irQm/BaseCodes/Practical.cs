using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class Practical : IQuestion
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public string Face { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float gainedScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> checkList { get; set; } = new List<string>();
        public List<string> Tags { get; set; } = new List<string>();
        public Lesson Lesson { get; set; }
    }
}
