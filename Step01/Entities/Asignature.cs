namespace CoreSchool.Entities
{
    public class Asignature
    {
        public string UniqueId {get; private set;}

        public string Name {get; set;}

         public List<Assessment> Assessments{get; set;} = new List<Assessment>();

        public Asignature()
        {
            UniqueId=Guid.NewGuid().ToString();
            Assessments= new List<Assessment>();
        }
    }
}