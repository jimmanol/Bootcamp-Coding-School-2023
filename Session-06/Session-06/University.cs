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
        public Student[]? Students { get; set; }

        public Course[]? Courses { get; set; }

        public Grade[]? Grades { get; set; }

        public Schedule[]? ScheduledCourse { get; set; }


        // constructors
        public University()
        {

        }
        public University(Guid id) : base(id)
        {

        }
        public University(Guid id, string name) : base(id, name)
        {

        }
        public University(Guid id, string name, int yearsInservice) : base(id, name, yearsInservice)
        {

        }
        public University(Guid id, string name, int yearsInservice, Student[] student) : base(id, name, yearsInservice)
        {
            Students = student;
        }
        public University(Guid id, string name, int yearsInservice, Student[] student, Course[] courses) : base(id, name, yearsInservice)
        {
            Students = student;
            Courses = courses;
        }
        public University(Guid id, string name, int yearsInservice, Student[] student, Course[] courses, Grade[] grades) : base(id, name, yearsInservice)
        {
            Students = student;
            Courses = courses;
            Grades = grades;
        }
        public University(Guid id, string name, int yearsInservice, Student[] student, Course[] courses, Grade[] grades, Schedule[] scheduledCourse) : base(id, name, yearsInservice)
        {
            Students = student;
            Courses = courses;
            Grades = grades;
            ScheduledCourse = scheduledCourse;
        }





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
