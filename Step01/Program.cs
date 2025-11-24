// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;

var school = new School("test school aby", 2000, SchoolTypes.Primary, country: "Colombia", city: "Bogota");

school.Courses = new List<Course>(){
    new Course() { Name="101", JournalType=JournalTypes.Partial},
    new Course() { Name="201", JournalType=JournalTypes.Final},
    new Course() { Name="301", JournalType=JournalTypes.Extraordinary}
};
    

school.Courses.Add( new Course(){
    Name="401",
    JournalType=JournalTypes.Partial
});

//school.Courses = null;

PrintSchoolCourses(school);

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




/* Console.WriteLine("Courses While: ");
PrintCoursesWhile(school.Courses);
Console.WriteLine("Courses Do While: ");
PrintCoursesDoWhile(school.Courses);
Console.WriteLine("Courses For: ");
PrintCoursesFor(school.Courses);
Console.WriteLine("Courses For Each: ");
PrintCoursesForEach(school.Courses);
 */
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

void PrintCoursesFor(Course[] arraryCourses)
{
    for (int i = 0; i < arraryCourses.Length; i++)
    {
        Console.WriteLine($"Name: {arraryCourses[i].Name}, JournalType: {arraryCourses[i].JournalType} Id: {arraryCourses[i].UniqueId}");
    }
}

void PrintCoursesForEach(Course[] arraryCourses)
{
    foreach (var course in arraryCourses)
    {
        Console.WriteLine($"Name: {course.Name}, JournalType: {course.JournalType} Id: {course.UniqueId}");
    }
}