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

            Random rnd=new Random();

            foreach (var course in School.Courses)
            {
                int cantStudents=rnd.Next(5,20);
                course.Students=GenerateStudents(cantStudents);
            }
        }
        private List<Student> GenerateStudents(int quantity=10)
        {
            string[] firstName={"Pedro","Luis","Miguel","Sofia","Isabella","Valentina"};
            string[] secondName={"Maria","Juan","Carlos","Ana","Luis","Carmen"};
            string[] lastName={"Alvarez","Gonzalez","Rodriguez","Lopez","Martinez","Perez"};

            var StudentList=from n1 in firstName
                            from n2 in secondName
                            from a1 in lastName
                            select new Student{Name=$"{n1} {n2} {a1}"};

            return StudentList.OrderBy(s => s.UniqueId).Take(quantity).ToList();
        }
        private void LoadAsignatures()
        {
            foreach (var course in School.Courses)
            {
                var AsignatureList=new List<Asignature>()
                {
                    new Asignature{Name="Math"},
                    new Asignature{Name="Spanish"},
                    new Asignature{Name="Science"},
                    new Asignature{Name="Arts"},
                    new Asignature{Name="Physical Education"} 
                };
                course.Asignatures= AsignatureList;
            }
        }
        private void LoadAssessments()
        {
            
        }
    }
}
