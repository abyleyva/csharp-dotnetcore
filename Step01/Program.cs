// See https://aka.ms/new-console-template for more information
using CoreSchool.Entities;

var school = new School("test school aby", 2000, SchoolTypes.Primary,country:"Colombia",city:"Bogota");

var Course1 = new Course()
{
    Name="101",
    JournalType=JournalTypes.Partial
};
var Course2 = new Course()
{
    Name="201",
    JournalType=JournalTypes.Final
};
var Course3 = new Course()
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
Console.WriteLine($"Course1: {Course1.Name}, JournalType: {Course1.JournalType} Id: {Course1.UniqueId}");
Console.WriteLine($"Course2: {Course2.Name}, JournalType: {Course2.JournalType} Id: {Course2.UniqueId}");
Console.WriteLine($"Course3: {Course3.Name}, JournalType: {Course3.JournalType} Id: {Course3.UniqueId}");
