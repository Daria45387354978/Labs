var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var taken = numbers.TakeWhile(n => n < 6);

foreach (var n in taken)
    Console.WriteLine(n);
