
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Введите координаты точки (x и y):");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                if (x == 0 && y == 0)
                {
                    Console.WriteLine("Точка находится в начале координат.");
                }
                else if (x == 0)
                {
                    Console.WriteLine("Точка находится на оси Y.");
                }
                else if (y == 0)
                {
                    Console.WriteLine("Точка находится на оси X.");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("Точка находится в первом квадранте.");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Точка находится во втором квадранте.");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Точка находится в третьем квадранте.");
                }
                else
                {
                    Console.WriteLine("Точка находится в четвертом квадранте.");
                }
            }
        }

    }


