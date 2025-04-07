using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = new[]
        {
            new { Name = "Аня", Age = 18 },
            new { Name = "Борис", Age = 19 },
            new { Name = "Света", Age = 20 },
            new { Name = "Игорь", Age = 21 },
            new { Name = "Фидель", Age = 22 }
        };

        var firstThree = students.Take(3);

        foreach (var student in firstThree)
        {
            Console.WriteLine($"{student.Name}, возраст: {student.Age}");
        }
    }
}
