using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Professor : Person
    {
        // properties

        public string? Rank { get; set; }
        public Course[] Courses { get; set; }


        // consrtructors






        // Methods

        public void SetGrade(Guid studentID, Guid courseID,int grade)
        {

        }

        public void Teach(string course, DateTime datetime)
        {


        }

        public void GetName()
        {

        }


    }
}

