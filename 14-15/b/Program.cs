using System;

class Program
{
    static void Main()
    {
        int[] a = { 5, 3, 9, 2 };
        int[] b = { 1, 4, 7, 6 };

        int N = a.Length;
        int S = 0;

        for (int i = 0; i < N; i++) 
        {
            S += Math.Abs(a[i] - b[i]);
        }

        Console.WriteLine("Сумма модулей разностей: " + S);
    }
}