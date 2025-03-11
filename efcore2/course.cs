using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace efcore2
{
    internal class course
    {
        public int id { get; set; }
        public string duration { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        
        public int topicid{ get; set; }
        public topic? topic { get; set; }

    }
}
