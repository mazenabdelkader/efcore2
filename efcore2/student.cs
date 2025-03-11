using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore2
{
    internal class student
    {
        public int id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        [ForeignKey("dept_id")]
        public int dept_id{ get; set; }
        public department department { get; set; }
        
    }
}
