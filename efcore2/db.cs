using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace efcore2
{
    internal class db: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-98Q3DDS ; database=mazen ; integrated security=true;Trusted_Connection=true; encrypt=false");


        }
        public DbSet<student> student { get; set; }
        public DbSet<course> courses { get; set; }
        //public DbSet<Course_inst> course_Insts { get; set; }
        public DbSet<instructor> instructors { get; set; }
        public DbSet<topic> topic { get; set; }
        public DbSet<department> departments { get; set; }
        //public DbSet<Stud_Course> stud_Courses { get; set; }
    }
}
