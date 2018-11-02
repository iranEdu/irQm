psusing System;
using System.Collections.Generic;

namespace irQm.BaseCodes
{
    public interface IQuestion
    {
        string Face { get; set; }
        float Score { get; set; }
        float gainedScore { get; set; }
        List<string> Tags { get; set; }
        bool AutomaticEvaluation { get; }
    }
}
