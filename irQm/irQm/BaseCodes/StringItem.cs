using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace irQm.BaseCodes
{
    [Serializable]
   
    public  class StringItem
    {
    
        public StringItem(byte number)
        {
            Number = number;
        }
        public StringItem()
        { }
        
        [MaxLength(50)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]

        public string Value { get; set; }
        public byte Number { get; set; }
    }
}
