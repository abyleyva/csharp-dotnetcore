namespace CoreSchool.Entities
{
    public class Student
    {
        public string UniqueId {get; private set;}
        public string Name{get; set;}
        public List<Assessment> Assessments{get; set;}

        public Student()
        {
           UniqueId= Guid.NewGuid().ToString();
           Assessments= new List<Assessment>();  
        } 
    }
}