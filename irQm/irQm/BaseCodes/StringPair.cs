using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
   public class StringPair
    {
        public StringPair()
        {

        }
        public StringPair(byte number)
        {
            Number = number;
        }
        [MaxLength(50), Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Key { get; set; } = "";
        [Required]
        public string Value { get; set; } = "";
        public byte Number { get; set; }

        
    }
}
