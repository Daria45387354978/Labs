var students = new[] { "Алексей", "Аня", "Мария" };
var scores = new[] { 85, 90, 75 };

var result = students.Zip(scores, (name, score) => new { name, score });

foreach (var s in result)
    Console.WriteLine($"{s.name}: {s.score}");
