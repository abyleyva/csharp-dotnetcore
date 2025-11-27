using CoreSchool.Entities;

namespace CoreSchool
{
    public class SchoolEngine
    {
        public School? School { get; set; }

        public SchoolEngine()
        {
            
        }
        public void Initialize()
        {
            School = new School("test school aby", 2000, SchoolTypes.Primary, country: "Colombia", city: "Bogota");
            
            LoadCourses();
            LoadAsignatures();
            foreach (var course in School.Courses)
            {
                course.Students.AddRange(LoadStudents());
            }
            LoadAssessments();
        }

        private void LoadCourses()
        {
            School.Courses = new List<Course>(){
                new Course() { Name="101", JournalType=JournalTypes.Partial},
                new Course() { Name="201", JournalType=JournalTypes.Final},
                new Course() { Name="301", JournalType=JournalTypes.Extraordinary},
                new Course() { Name="401", JournalType=JournalTypes.Final},
                new Course() { Name="501", JournalType=JournalTypes.Extraordinary}
            };
        }
        private IEnumerable<Student> LoadStudents()
        {
            string[] firstName={"Pedro","Luis","Miguel","Sofia","Isabella","Valentina"};
            string[] secondName={"Maria","Juan","Carlos","Ana","Luis","Carmen"};
            string[] lastName={"Alvarez","Gonzalez","Rodriguez","Lopez","Martinez","Perez"};

            var StudentList=from n1 in firstName
                            from n2 in secondName
                            from a1 in lastName
                            select new Student{Name=$"{n1} {n2} {a1}"};

            return StudentList;
        }
        private void LoadAsignatures()
        {
            foreach (var course in School.Courses)
            {
                var AsignatureList=new List<Asignature>()
                {
                    new Asignature{name="Math"},
                    new Asignature{name="Spanish"},
                    new Asignature{name="Science"},
                    new Asignature{name="Arts"},
                    new Asignature{name="Physical Education"} 
                };
                course.Asignature.AddRange(AsignatureList);
            }
        }
        private void LoadAssessments()
        {
            
        }
    }
}
