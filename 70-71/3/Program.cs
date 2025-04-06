public class Program
{
    public class Books
    {
        public string Title;
        public string Author;
    }

    public static Books[] books =
         {
                new() { Title = "Война и мир", Author = "Лев Толстой" },
                new() { Title = "1984", Author = "Джордж Оруэлл" },
                new() { Title = "Собачье сердце", Author = "Михаил Булгаков" },

            };


    static void Main(string[] args)
    {
        Console.WriteLine(books.First(x => x.Author == "Лев Толстой").Title);
    }

}
