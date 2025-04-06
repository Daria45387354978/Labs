using System;

public class massiv
{
    public static void SortMassiv(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[maxIndex])
                {
                    maxIndex = j;
                }
            }
            int temp = arr[maxIndex];
            arr[maxIndex] = arr[i];
            arr[i] = temp;
        }
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 64, 25, 12, 22, 11 };
        Console.WriteLine("Несортированный массив:");
        PrintArray(numbers);

        SortMassiv(numbers);
        Console.WriteLine("\nОтсортированный массив (по убыванию):");
        PrintArray(numbers);
    }
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
