class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 4, 6, 3, 8, 7 };
        Console.WriteLine("Массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        int firstEl = array[0];

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] % 2 == 0)
            {
                array[i] += firstEl;
            }
        }
        Console.WriteLine("\nПреобразованный массив: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
