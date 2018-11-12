using System;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{
    public class Option : IOption
    {
        [MaxLength(50)]
        public string Id{get;set;}
        public bool Answered { get; set; }
        [Required]
        string  Face { get; set; }
        [Required]
        public bool IsTrue { get; set ; }
        public byte number { get ; set ; }
    }
}
