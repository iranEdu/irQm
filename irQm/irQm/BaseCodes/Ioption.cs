using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    interface IOption
    {
        bool IsTrue { get; set; }
        bool Answered { get; set; } 
    }
}
