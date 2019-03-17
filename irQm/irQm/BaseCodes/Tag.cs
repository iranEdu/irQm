using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    [Serializable]
   public class Tag
    {
        [Key]
        public string Value { get; set; }
    }
}
