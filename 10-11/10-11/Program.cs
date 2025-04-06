internal class Program
{
    static void Main(string[] args)
    {

        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double modA = Math.Abs(a);
            double modB = Math.Abs(b);
            double modC = Math.Abs(c);

            double arithmeticMean = (modA + modB + modC) / 3;

            double geometricMean = Math.Pow(modA * modB * modC, 1.0 / 3.0);

            Console.WriteLine($"Среднее арифметическое модулей: {arithmeticMean}");
            Console.WriteLine($"Среднее геометрическое модулей: {geometricMean}");
        }
    }

}

