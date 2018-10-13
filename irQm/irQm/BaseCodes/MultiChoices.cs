﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace irQm.BaseCodes
{
    public class MultiChoices : IQuestion,IEvaluable
    {
        public List<Option> Options { get; set; }

        public string Face { get; set; }
        public float Score { get; set; }
        public float gainedScore { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        bool multi;
        public bool MultiSelections { get { return multi; }set { multi = value && Options.Count(o => o.IsTrue) > 1; } }
        public void Mix() { }

        public void Evaluate()
        {
            var c = Options.Count(o => o.IsTrue);

            if (c > 0)
            {
                var g = Score * ( Options.Count(o => o.IsTrue && o.Answered) - Options.Count(o=> o.Answered&& !o.IsTrue))/c;
                if (g < 0)
                    g = 0;
                gainedScore = g;
            }

        }
    }
}
