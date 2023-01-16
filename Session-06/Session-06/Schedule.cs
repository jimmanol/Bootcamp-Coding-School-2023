using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Schedule
    {
        //properties

        public Guid ID { get; set; }

        public Guid CourseID { get; set; }

        public Guid ProfessorID { get; set; }

        public DateTime Calendar { get; set; }


        // constructors

        public Schedule()
        {

        }

        public Schedule(Guid id)
        {
            ID = id;
        }

        public Schedule(Guid id, Guid professorId)
        {
            ID = id;
            ProfessorID = professorId;
        }
        public Schedule(Guid id, Guid professorId, Guid courseId)
        {
            ID = id;
            ProfessorID = professorId;
            CourseID = courseId;
        }
        public Schedule(Guid id, Guid professorId, Guid courseId, DateTime calendar)
        {
            ID = id;
            ProfessorID = professorId;
            CourseID = courseId;
            Calendar = calendar;
        }

    }
}
