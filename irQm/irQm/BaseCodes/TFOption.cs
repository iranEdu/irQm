using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    class TFOption : IOption
    {
        [MaxLength(50)]
        public string Id { get; set; }
        public bool IsTrue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Answered { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
