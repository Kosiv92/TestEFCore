using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCore
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }

        public Role Role { get; set; }

        //public Guid RoleId { get; set; }
    }
}
