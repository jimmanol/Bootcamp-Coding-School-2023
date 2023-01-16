using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class University : Institute
    {
        // properties
        public Student[] Students { get; set; }

        public Course[] Courses { get; set; }

        public Grade[] Grades { get; set; }

        public Schedule[] ScheduledCourse { get; set; }



        // methods

        public void GetStudent()
        {

        }
        public void GetCourse()
        {

        }
        public void GetGrades()
        {

        }
        public void SetSchedule(Guid courseID,Guid professorID, DateTime datetime)
        {

        }

    }
}
