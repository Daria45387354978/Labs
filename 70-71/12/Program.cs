using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var courses = new[]
        {
            new { CourseName = "Математика", Students = new[] { "Аня", "Борис" } },
            new { CourseName = "Физика", Students = new[] { "Света", "Игорь", "Фидель" } }
        };

        var allStudents = courses.SelectMany(c => c.Students);

        foreach (var student in allStudents)
        {
            Console.WriteLine(student);
        }
    }
}
