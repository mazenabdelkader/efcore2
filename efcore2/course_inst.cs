using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace efcore2
{
    [Keyless]
    internal class course_inst
    {
        public course course_id { get; set; }
        public instructor inst_id { get; set; }
        public int evalute { get; set; }
    }
}
