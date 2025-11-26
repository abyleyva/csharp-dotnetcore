// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;
using CoreSchool.Util;


var engine = new CoreSchool.SchoolEngine();
engine.Initialize();

if (engine.School != null)
{
    PrintSchoolCourses(engine.School);
}

void PrintSchoolCourses(School school)
{
    Printer.WriteHeader($"Welcomes to {school.Name}!");
    Printer.WriteHeader("List of Courses");

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