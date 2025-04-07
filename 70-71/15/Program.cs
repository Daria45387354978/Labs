var orders = new[]
{
    new { OrderId = 1, Product = "Шоколад", Quantity = 3 },
    new { OrderId = 2, Product = "Чай", Quantity = 5 },
    new { OrderId = 3, Product = "Шоколад", Quantity = 2 },
    new { OrderId = 4, Product = "Кофе", Quantity = 1 },
    new { OrderId = 5, Product = "Чай", Quantity = 4 }
};

var grouped = orders
    .GroupBy(o => o.Product)
    .Select(g => new { Product = g.Key, Total = g.Sum(x => x.Quantity) });

foreach (var g in grouped)
    Console.WriteLine($"{g.Product}: {g.Total} шт.");
