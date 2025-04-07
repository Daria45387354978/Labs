using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var genres = new[]
        {
            new { Name = "Фантастика" },
            new { Name = "Драма" },
            new { Name = "Приключения" },
            new { Name = "Фантастика" },
            new { Name = "Комедия" },
        };

        var uniqueGenres = genres
            .Select(g => g.Name)
            .Distinct();

        foreach (var genre in uniqueGenres)
        {
            Console.WriteLine(genre);
        }
    }
}
