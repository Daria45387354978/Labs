
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        string input = Console.ReadLine();


        if (int.TryParse(input, out int n) && n > 0)
        {
            int sum = 0;


            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine($"Сумма цифр числа: {sum}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное натуральное число.");
        }
    }
}
