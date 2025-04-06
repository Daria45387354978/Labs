using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        CountVowelsAndConsonants(input);
    }

    static void CountVowelsAndConsonants(string text)
    {
        string vowels = "AEIOUYАЕЁИОУЫЭЮЯaeiouyаеёиоуыэюя";
        int vowelsCount = 0;
        int consonantsCount = 0;

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                if (vowels.Contains(c))
                    vowelsCount++;
                else
                    consonantsCount++;
            }
        }

        Console.WriteLine($"Гласных: {vowelsCount}, Согласных: {consonantsCount}");
    }
}
