namespace CoreSchool.Entities
{
    public class Assessments
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Asignature Asignature{get; set;}
        public float Note{get; set;}
        public Assessments()=>UniqueId=Guid.NewGuid().ToString();
    }
}