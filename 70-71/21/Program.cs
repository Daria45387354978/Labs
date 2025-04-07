var studentGrades = new[]
{
    new { Name = "Аня", Subject = "Математика", Grade = 5 },
    new { Name = "Борис", Subject = "Математика", Grade = 4 },
    new { Name = "Аня", Subject = "Физика", Grade = 5 },
    new { Name = "Борис", Subject = "Физика", Grade = 3 },
};

var averages = studentGrades
    .GroupBy(s => s.Name)
    .Select(g => new { Student = g.Key, Average = g.Average(x => x.Grade) });

foreach (var a in averages)
    Console.WriteLine($"{a.Student}: средняя оценка = {a.Average:F2}");
