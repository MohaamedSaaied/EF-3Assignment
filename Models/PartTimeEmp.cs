using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_3InhertanceExample.Models
{
    internal class PartTimeEmp:Employee
    {
        public int NumOfHour { get; set; }
        public double HoureRate { get; set; }
    }
}
