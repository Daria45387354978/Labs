var students = new[]
{
    new { Name = "Анна", Score = 85 },
    new { Name = "Иван", Score = 95 },
    new { Name = "Мария", Score = 90 },
    new { Name = "Дмитрий", Score = 78 },
    new { Name = "Светлана", Score = 88 },
};

var top3 = students
    .OrderByDescending(s => s.Score)
    .Take(3);

foreach (var s in top3)
    Console.WriteLine($"{s.Name}: {s.Score}");
