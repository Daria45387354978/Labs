var services = new[]
{
    new { ServiceName = "Стрижка", Price = 500 },
    new { ServiceName = "Укладка", Price = 1000 },
    new { ServiceName = "Маникюр", Price = 700 }
};

var serviceList = services
    .Select(s => new { s.ServiceName, s.Price })
    .ToList();

serviceList.ForEach(s => Console.WriteLine($"{s.ServiceName} — {s.Price} руб."));
