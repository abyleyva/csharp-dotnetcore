using System.Security.Authentication;

namespace CoreSchool.Entities
{
    class School
    {
        string name;
        public string Name
        {
            get { return name; }
            set {name=value.ToUpper(); }
        }

        public int YearOfFoundation { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        
        /* public School(string name,int yearOfFoundation)
        {
            this.name = name.ToUpper();
            this.YearOfFoundation = yearOfFoundation;
        }
 */
        public SchoolTypes SchoolType { get; set; }
        public Course[] Courses { get; set; }

        

        public School(string name,int year)=>(Name, YearOfFoundation)=(name.ToUpper(), year);

        public School(string name,int year, SchoolTypes schoolType,string country="",string city="")
        {
            (Name,YearOfFoundation)=(name.ToUpper(), year);
            Country=country;
            City=city;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Year: {YearOfFoundation}, Country: {Country}, City: {City}, {System.Environment.NewLine} SchoolType: {SchoolType}";
        }
    }

}