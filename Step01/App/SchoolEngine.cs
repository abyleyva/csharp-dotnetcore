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
            
            School.Courses = new List<Course>(){
                new Course() { Name="101", JournalType=JournalTypes.Partial},
                new Course() { Name="201", JournalType=JournalTypes.Final},
                new Course() { Name="301", JournalType=JournalTypes.Extraordinary},
                new Course() { Name="401", JournalType=JournalTypes.Final},
                new Course() { Name="501", JournalType=JournalTypes.Extraordinary}
            };
        }
    }
}
