using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var movies = new[]
        {
            new { Title = "Терминатор", Year = 1984 },
            new { Title = "Матрица", Year = 1999 },
            new { Title = "Начало", Year = 2010 },
            new { Title = "Интерстеллар", Year = 2014 },
        };

        var lastMovie = movies
            .OrderBy(m => m.Year)
            .Last();

        Console.WriteLine($"Последний фильм по году выпуска: {lastMovie.Title} ({lastMovie.Year})");
    }
}
