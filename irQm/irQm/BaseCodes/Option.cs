using System;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    public class Option : IOption
    {
        [MaxLength(50)]
        public string Id{get;set;}
        public bool Answered { get; set; }
        string  Face { get; set; }
        
        public bool IsTrue { get; set ; }

    }
}
