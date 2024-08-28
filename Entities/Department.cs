using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_3.Entities
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
