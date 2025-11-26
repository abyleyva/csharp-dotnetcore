namespace CoreSchool.Util
{
    public static class Printer
    {
        public static void drawLine(int length = 10)
        {
            Console.WriteLine("".PadLeft(length, '+'));
        }
        public static void WriteHeader(string title)
        {
            // Implementation for writing a header can be added here
            var length = title.Length + 4;
            drawLine(length);
            Console.WriteLine($"| {title} |");
            drawLine(length);
       }
    }
}