using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcore2
{
    internal class department
    {
        public int id { get; set; }
        public string name { get; set; }
       
        public string hiring_date { get; set; }
        [ForeignKey("insid")]
        
        public int insid { get; set; }
        //public instructor insid { get; set; }
    }
}
