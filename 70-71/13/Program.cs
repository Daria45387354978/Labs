var customers = new[]
{
    new { CustomerId = 1, Name = "Иван" },
    new { CustomerId = 2, Name = "Алексей" },
};

var orders = new[]
{
    new { OrderId = 101, CustomerId = 1 },
    new { OrderId = 102, CustomerId = 2 },
    new { OrderId = 103, CustomerId = 1 },
};

var joined = orders.Join(customers,
    order => order.CustomerId,
    customer => customer.CustomerId,
    (order, customer) => new { order.OrderId, CustomerName = customer.Name });

foreach (var o in joined)
    Console.WriteLine($"Заказ {o.OrderId}, Клиент: {o.CustomerName}");
