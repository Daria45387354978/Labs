
    internal class Program
    {
        class Students
        {
            public int Age;
            public string Name;
        }
        static void Main(string[] args)
        {
            Students[] students = [];
            var filteredStudents = new List<string>();

            filteredStudents.AddRange(students.Where(s => s.Age > 20).Select(s => s.Name));

            foreach (var name in filteredStudents)
            {
                Console.WriteLine(name);
            }
        }
    }

