
class Program
{
    static void Main()
    {
        var products = new[]
        {
            new { Name = "Яблоко", Price = 100 },
            new { Name = "Банан", Price = 80 },
            new { Name = "Груша", Price = 120 },
        };

        var productNames = products.Select(p => p.Name);

        foreach (var name in productNames)
        {
            Console.WriteLine(name);
        }
    }
}
