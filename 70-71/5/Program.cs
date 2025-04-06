public class Program
{
    public class Students
    {
        public string Name;
        public int Grade;
    }

    public static Students[] students =
         {
                new() { Name = "Алексей", Grade = 5 },
                new() { Name = "Мария", Grade = 4 },
                new() { Name = "Дмитрий", Grade = 5 },
                new() { Name = "Елена", Grade = 3 },

            };


    static void Main(string[] args)
    {
        Students[] five = students.Where(s => s.Grade == 5).ToArray();
        Students[] four = students.Where(s => s.Grade == 4).ToArray();
        Students[] three = students.Where(s => s.Grade == 3).ToArray();

        Console.WriteLine(string.Join("\n", five.Select(s => $"{s.Name} - {s.Grade}")));
        Console.WriteLine();
        Console.WriteLine(string.Join("\n", four.Select(s => $"{s.Name} - {s.Grade}")));
        Console.WriteLine();
        Console.WriteLine(string.Join("\n", three.Select(s => $"{s.Name} - {s.Grade}")));
    }

}
