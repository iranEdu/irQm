using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irQm.BaseCodes
{
    public class Roles
    {
        public enum RoleSNames { Admin,limited }
        
        public class RoleType
        {
            public string Name { get; set; }
            public RoleSNames Value { get; set; }
            public RoleType(string name, RoleSNames value)
            {
                Name = name; Value = value;
            }
        }
        public static RoleType[] Names = { new RoleType( "مدیر", RoleSNames.Admin),
               new RoleType( "محدود",RoleSNames.limited)
                    };
    }
}
