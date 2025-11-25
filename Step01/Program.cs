// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;


var engine = new CoreSchool.SchoolEngine();
engine.Initialize();


PrintSchoolCourses(engine.School);


void PrintSchoolCourses(School school)
{
    Console.WriteLine(school.Name);
    Console.WriteLine("++++++++++++++++++++");
    Console.WriteLine("List of Courses: ");
    Console.WriteLine("++++++++++++++++++++");

    if (school?.Courses != null)
    {
        foreach (var course in school.Courses)
        {
            Console.WriteLine($"Name: {course.Name}, JournalType: {course.JournalType} Id: {course.UniqueId}");

        }
    }
    else
    {
        Console.WriteLine("The school has no courses registered.");
    }

}