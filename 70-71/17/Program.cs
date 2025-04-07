var products = new[]
{
    new { Name = "Яблоко", Price = 100, IsAvailable = true },
    new { Name = "Банан", Price = 80, IsAvailable = false },
    new { Name = "Груша", Price = 120, IsAvailable = true },
    new { Name = "Апельсин", Price = 90, IsAvailable = false }
};

bool hasExpensiveAvailable = products.Any(p => p.IsAvailable && p.Price > 90);
Console.WriteLine($"Есть ли доступные продукты дороже 90? {hasExpensiveAvailable}");
