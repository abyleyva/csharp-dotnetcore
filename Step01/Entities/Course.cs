namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string? Name { get; set; }   
        public JournalTypes JournalType { get; set; }

        public List<Asignature>? Asignatures { get; set; }
        public List<Student>? Students {get; set;}

        public Course()=>UniqueId = Guid.NewGuid().ToString();
    }

}