internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки (x, y):");
        Console.Write("x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        DeterminePosition(x, y);
    }

    static void DeterminePosition(double x, double y)
    {
        if (x == 0 && y == 0)
        {
            Console.WriteLine("Точка находится в начале координат.");
            return;
        }

        if (x == 0)
        {
            Console.WriteLine("Точка находится на оси Y.");
            return;
        }

        if (y == 0)
        {
            Console.WriteLine("Точка находится на оси X.");
            return;
        }

        goto DetermineQuadrant;

    DetermineQuadrant:
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в 1-м квадранте.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во 2-м квадранте.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в 3-м квадранте.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в 4-м квадранте.");
        }
    }
}
