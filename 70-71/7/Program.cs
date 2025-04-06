using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var clients = new[]
        {
            new { Name = "Андрей", IsActive = false },
            new { Name = "Светлана", IsActive = true },
            new { Name = "Николай", IsActive = false },
        };

        bool hasActiveClients = clients.Any(c => c.IsActive);

        if (hasActiveClients)
        {
            Console.WriteLine("Есть активные клиенты.");
        }
        else
        {
            Console.WriteLine("Активных клиентов нет.");
        }
    }
}
