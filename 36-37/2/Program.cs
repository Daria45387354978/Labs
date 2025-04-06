using System;
using System.Text;

class Program
{
    static void Main()
    {
        string randomString = GenerateRandomString(32);
        Console.WriteLine("Случайная строка (32 символа): " + randomString);
    }

    static string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        StringBuilder result = new StringBuilder();
        Random rnd = new Random();

        for (int i = 0; i < length; i++)
        {
            result.Append(chars[rnd.Next(chars.Length)]);
        }

        return result.ToString();
    }
}
