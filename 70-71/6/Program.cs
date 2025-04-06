using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var movies = new[]
        {
            new { Title = "Звёздные войны", Genre = "Фантастика" },
            new { Title = "Зелёная миля", Genre = "Драма" },
            new { Title = "Властелин колец", Genre = "Фантастика" },
        };

        int sciFiCount = movies.Count(m => m.Genre == "Фантастика");
        Console.WriteLine($"Фантастика: {sciFiCount}");
    }
}
