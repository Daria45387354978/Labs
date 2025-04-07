public class Program
{
    public class Cars
    {
        public string Brand;
        public int Year;
    }

    public static Cars[] cars =
         {
                new() { Brand = "Toyota", Year = 2020 },
                new() { Brand = "Honda", Year = 2018 },
                new() { Brand = "Ford", Year = 2021 }

            };


    static void Main(string[] args)
    {
        Console.WriteLine(string.Join("\n", cars.OrderBy(c => c.Year).Select(s => $"{s.Brand} - {s.Year}")));
    }

}
