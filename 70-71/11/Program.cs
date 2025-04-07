using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var books = new[]
        {
            new { Title = "1984", Author = "Джордж Оруэлл" },
            new { Title = "Гарри Поттер", Author = "Дж.К. Роулинг" },
            new { Title = "Война и мир", Author = "Лев Толстой" },
            new { Title = "Мастер и Маргарита", Author = "Михаил Булгаков" },
            new { Title = "Убить пересмешника", Author = "Харпер Ли" }
        };

        var skippedBooks = books.Skip(2);

        foreach (var book in skippedBooks)
        {
            Console.WriteLine($"{book.Title} — {book.Author}");
        }
    }
}
