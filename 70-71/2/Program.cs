
    public class Program
    {
        public class Employee
        {
            public string Name;
            public int Age;
            public string Department;
        }

        public static Employee[] employees =
            {
                new() { Name = "Иван", Age = 28, Department = "IT" },
                new() { Name = "Мария", Age = 34, Department = "HR" },
                new() { Name = "Анна", Age = 25, Department = "Finance" },
                new() { Name = "Дмитрий", Age = 30, Department = "IT" },
            };

        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", employees.Where(e => e.Department == "IT").Select(s => $"{s.Name} в {s.Department}")));
        }

    }

