namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }   
        public JournalTypes JournalType { get; set; }

        public Course()=>UniqueId = Guid.NewGuid().ToString();
    }

}