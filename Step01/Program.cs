// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;

var school = new School("test school aby", 2000, SchoolTypes.Primary,country:"Colombia",city:"Bogota");

var arraryCourses=new Course[3];

arraryCourses[0]=new Course()
{
    Name="101",
    JournalType=JournalTypes.Partial
};

var Course2 = new Course()
{
    Name="201",
    JournalType=JournalTypes.Final
};
arraryCourses[1]=Course2;

arraryCourses[2]=new Course
{
    Name="301",
    JournalType=JournalTypes.Extraordinary
};

//school.Country = "USA";
//school.City = "New York";
//school.SchoolType=SchoolTypes.Secondary;
Console.WriteLine(school.Name);
Console.WriteLine(school);
System.Console.WriteLine("++++++++++=++++++++++");

Console.WriteLine("Courses While: ");
PrintCoursesWhile(arraryCourses);
Console.WriteLine("Courses Do While: ");
PrintCoursesDoWhile(arraryCourses);

void PrintCoursesWhile(Course[] arraryCourses)
{
    int count = 0;
    while (count < arraryCourses.Length)
    {
        Console.WriteLine($"Name: {arraryCourses[count].Name}, JournalType: {arraryCourses[count].JournalType} Id: {arraryCourses[count].UniqueId}");
        count++;
    }
    
}

void PrintCoursesDoWhile(Course[] arraryCourses)
{
    int count = 0;
    do
    {
        Console.WriteLine($"Name: {arraryCourses[count].Name}, JournalType: {arraryCourses[count].JournalType} Id: {arraryCourses[count].UniqueId}");
        count++;
    } while (count < arraryCourses.Length);
}