using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore2
{
    internal class instructor
    {
        public int id { get; set; }
        public int bonus { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string address { get; set; }
        public int hourrate { get; set; }
        [ForeignKey(nameof(department))]
        public int dept_id { get; set; }
        public department mangedepartment { get; set; }
        public department department { get; set; }
    }
}
