var incomes = new[] { 50000, 75000, 64000, 48000, 54000 };

var total = incomes.Aggregate((sum, next) => sum + next);
Console.WriteLine($"Общий доход: {total} руб.");
