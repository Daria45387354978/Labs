using System;

class Program
{
    static void Main()
    {
        int M = 5;
        int S = 0;

        for (int n = 1; n <= M; n++) // цикл с параметром
        {
            S += n * n;
        }

        Console.WriteLine("Сумма квадратов от 1 до " + M + ": " + S);
    }
}