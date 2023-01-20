using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib {
    public class Grade {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }

        public Guid CourseID { get; set; }
        public int Grades { get; set; }

        public Grade() {
            ID = Guid.NewGuid();
        }


        //public Grade(Guid id, Guid studentId, Guid courseId, int grades) {
        //    ID = id;
        //    StudentID = studentId;
        //    CourseID = courseId;
        //    Grades = grades;
        //}
    }
}
