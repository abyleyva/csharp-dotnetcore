// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var MySchool = new School();
MySchool.name = "Greenwood High";
MySchool.address = "123 Maple Street";
MySchool.yearFounded = 1995;
Console.WriteLine("Ringing the school bell...");
MySchool.RingBell();
class School
{
    public string name;
    public string address;
    public int yearFounded;
    public string principalName;

    public void RingBell()
    {
        Console.Beep(1000, 2000);
    }
}