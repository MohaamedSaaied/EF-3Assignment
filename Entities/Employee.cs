using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_3.Entities
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public string address { get; set; }
        public int Deptid { get; set; }
        public virtual Department workfor { get; set; }

    }
}
