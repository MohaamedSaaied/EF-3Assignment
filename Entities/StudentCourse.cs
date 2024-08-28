using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_3.Entities
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public virtual Student student { get; set; }
        public virtual Course course { get; set; }
        public int grade { get; set; }

    }
}
