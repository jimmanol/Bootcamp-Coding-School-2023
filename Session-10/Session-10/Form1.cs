using System.Text.Json;
using UniversityLib;

namespace Session_10 {
    public partial class Form1 : Form {

        List<Student> students;
        List<Grade> grades;
        List<Course> courses;
        List<Schedule> scheduled;

        


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            SetControlProperties();
            PopulateStudents();
            PopulateCourses();
            PopulateGrades();
            PopulateSchedule();


        }

        private void PopulateStudents() {

            List<University> unis = GetUniversities();

            students = new List<Student>();

            Student student1 = new Student() {
                Name = "Dimitris",
                Surname = "Raptodimos",
                Gender = Student.GenderEnum.Male,
                Age = 40,
                Undergraduate = false,
                UniversityID = unis[0].ID,
            };
            students.Add(student1);

            Student student2 = new Student() {
                Name = "Fotis",
                Surname = "Chrysoulas",
                Gender = Student.GenderEnum.Male,
                Age = 44,
                Undergraduate = true,
                UniversityID = unis[1].ID
            };
            students.Add(student2);


            bsStudents.DataSource = students;
        }

        private void PopulateGrades() {
           
            grades = new List<Grade>();

            Grade grade1 = new Grade() {
                StudentID = students[0].ID,
                CourseID = courses[0].ID,
                Grades = 16
            };
            grades.Add(grade1);

            Grade grade2 = new Grade() {
                StudentID = students[1].ID,
                CourseID = courses[1].ID,
                Grades = 19
            };
            grades.Add(grade2); ;
            grvGrades.DataSource = grades;
        }

        private void PopulateCourses() {
            

            courses = new List<Course>();

            Course course1 = new Course() {
                Code = "OOP1",
                Subject = "Object Or. Programing"
            };
            courses.Add(course1);

            Course course2 = new Course() {
                Code = "MA1",
                Subject = "Mathimatical Analysis"
            };
            courses.Add(course2); ;
            grvCourses.DataSource = courses;
        }

        private void PopulateSchedule() {
            
            

            scheduled = new List<Schedule>();

            Schedule scheduled1= new  Schedule() {
                ProfessorID = Guid.NewGuid(),  //didn't implement Professor.cs from Session-06 yet
                CourseID = courses[0].ID,
                Calendar = DateTime.Now.AddDays(5)
            };
            scheduled.Add(scheduled1);

            Schedule scheduled2 = new Schedule() {
                ProfessorID = Guid.NewGuid(),  //didn't implement Professor.cs from Session-06 yet
                CourseID = courses[1].ID,
                Calendar = DateTime.Today.AddDays(10)

            };
            scheduled.Add(scheduled2);
            grvSchedule.DataSource = scheduled;

        }





        private List<University> GetUniversities() {


            Guid id = Guid.Parse("{72F9974A-370C-4FCE-AD99-9A73FC089E60}");

            University uni1 = new University(id) {
                Name = "NTUA",
                Region = "Athens"
            };

            id = Guid.Parse("{D3DB7E60-9BDA-41F3-9FDE-A39C77FE03A9}");
            University uni2 = new University(id) {
                Name = "UNIPI",
                Region = "Peiraeus"
            };

            University uni3 = new University(Guid.Empty) {
            };

            List<University> universities = new List<University>() { uni1, uni2, uni3 };
            return universities;
        }

        private void SetControlProperties() {

            grvStudents.AutoGenerateColumns = false;
            grvStudents.DataSource = bsStudents;

            DataGridViewComboBoxColumn colGender = grvStudents.Columns["colGender"] as DataGridViewComboBoxColumn;
            colGender.Items.Add(Student.GenderEnum.Male);
            colGender.Items.Add(Student.GenderEnum.Female);
            colGender.Items.Add(Student.GenderEnum.Other);

            DataGridViewComboBoxColumn colUniversity1 = grvStudents.Columns["colUniversity"] as DataGridViewComboBoxColumn;
            colUniversity1.DataSource = GetUniversities();
            colUniversity1.DisplayMember = "Name";
            colUniversity1.ValueMember = "ID";

            grvStudents.CellContentClick += GrvStudents_CellContentClick;

        }

        private void GrvStudents_CellContentClick(object? sender, DataGridViewCellEventArgs e) {

            var grv = (DataGridView)sender;


            DataGridViewButtonColumn col = grv.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (col != null && col.Name == "colShowID" && e.RowIndex >= 0) {
                Student student = grv.CurrentRow.DataBoundItem as Student;
                MessageBox.Show($"The ID of student {student.Surname} {student.Name} is {student.ID}");
            }
        }

       

       

        private void grvStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

        }

        private void grvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void grvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void grvGrades_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        


        
        // LOAD/SAVE buttons

        private void btnLoad_Click(object sender, EventArgs e) {   //Can't deserialize Students because its an array

            Serializer serializer = new Serializer();
            //Student student1 = new Student() {
            //    Name = "Dimitris",
            //    Surname = "Raptodimos",
            //    Gender = Student.GenderEnum.Male,
            //    Age = 40,
            //    Undergraduate = false,
            //    UniversityID = Guid.NewGuid(),
            //};
            //serializer.SerializeToFile(student1, "Students.json");
            //Student s = new Student();
            students = JsonSerializer.Deserialize<List<Student>>("Students.json");
            //students = serializer.Deserialize<List<Student>>("Students.json");


            MessageBox.Show("Loaded!");
        }

        private void btnSave_Click(object sender, EventArgs e) {

            Serializer serializer = new Serializer();

            serializer.SerializeToFile(students, "Students.json");
            serializer.SerializeToFile(grades, "Grades.json");
            serializer.SerializeToFile(scheduled, "Schedule.json");
            serializer.SerializeToFile(courses, "Courses.json");

            MessageBox.Show("Saved!");
        }
    }
}