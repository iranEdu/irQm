using System;
using System.ComponentModel.DataAnnotations;

namespace irQm.BaseCodes
{[Serializable]
    public class Option : IOption
    {

        [MaxLength(50)]
        public string Id{get;set;}
        public bool Answered { get; set; }
        [Required]
        public string  Face { get; set; }
        [Required]
        public bool IsTrue { get; set ; }
        public byte number { get ; set ; }
        public string MultiChoicesId { get; set; }
  
    }
}
