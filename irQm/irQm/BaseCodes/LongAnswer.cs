using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class LongAnswer : IQuestion
    {
        public string Face { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float gainedScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Answer { get; private set; }
        public List<string> Tags { get; set; } = new List<string>();

        public bool AutomaticEvaluation { get { return false; } }
    }
}
