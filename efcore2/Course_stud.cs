using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace efcore2
{
  
    [Keyless]
    internal class Course_stud
    {
        public student stud_id { get; set; }
        public course course_id { get; set; }
        public int grade { get; set; }
    }
}
