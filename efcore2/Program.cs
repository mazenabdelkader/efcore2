using Microsoft.EntityFrameworkCore;

namespace efcore2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            db dB = new db();
            dB.student.Where(e => e.id == 1);
            dB.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            var student = new student()
            {
               
                address = "cairo",
                age = 34,
                Fname = "mazen",
                Lname = "abdelkader",
                dept_id = 1,

            };
            var course = new course() { description = "dsfds", duration = "2014", name = "maths", top_Id = 1 };


            var topic = new topic()
            {
               
                name = " mm"

            };

            var instructor = new instructor()
            {
               
                address = "alex",
                bonus = 22,
                dept_id = 1,
                salary = 1,
                hourrate = 1,
                name = "ahmed"

            };
            var department = new department()
            {
               
                hiring_date = "2012"
            ,
                ins_id = 1,
                name = "selling"
            };

            dB.student.Add(student);
            dB.courses.Add(course);
            dB.departments.Add(department);
            dB.topic.Add(topic);
            dB.instructors.Add(instructor);

            dB.SaveChanges();
        }
    }
}
