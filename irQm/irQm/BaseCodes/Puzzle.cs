using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class Puzzle : IQuestion
    {
        public string Face { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float gainedScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Tags { get ; set; } = new List<string>();
        public List<IDictionary<string, string>> Pairs { get; set; } = new List<IDictionary<string, string>>();
        public List<string> ExtraAnswers { get; set; } = new List<string>();

        public bool AutomaticEvaluation => true;
    }
}
