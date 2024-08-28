using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_3InhertanceExample.Models
{
    internal abstract class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
    }
}
