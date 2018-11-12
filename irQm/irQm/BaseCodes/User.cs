using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    public class User
    {
        [MaxLength(50),Key]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime RegisterTime = DateTime.UtcNow;
        public Roles.RoleSNames Role { get; set; }
    }
}
