using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        Console.Write("Введите символ, который нужно заменить: ");
        char oldChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Введите символ, на который заменить: ");
        char newChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        string result = input.Replace(oldChar, newChar);

        Console.WriteLine("Результат замены: " + result);
    }
}

