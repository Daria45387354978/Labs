using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        int temp = n;

        do
        {
            sum += temp % 10;
            temp /= 10;
        } while (temp > 0);

        Console.WriteLine("Сумма цифр числа: " + sum);
    }
}
