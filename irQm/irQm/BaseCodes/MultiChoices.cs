using System;
using System.Collections.Generic;
namespace irQm.BaseCodes
{
    public class MultiChoices : IQuestion
    {
        public List<Option> Options { get; set; }
        [MaxLength(50)]
        public string Id { get; private set; }
        public string Face { get; set; } 
        public float Score { get; set; }
        public float gainedScore { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public bool MultiSelections { get; private set; }
        public void Mix() { }
        public bool AutomaticEvaluation { get { return true; } }

    }
}
