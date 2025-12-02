namespace CoreSchool.Entities
{
    public class Assessment
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Asignature Asignature{get; set;}
        public float Note{get; set;}
       
       override public string ToString()
        {
            return $"Student: {Student.Name}, Asignature: {Asignature.Name}, Note: {Note}";
        }

        public Assessment()=>UniqueId=Guid.NewGuid().ToString();

    }
}