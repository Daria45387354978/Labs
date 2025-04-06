using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Program
{
    static List<T> Find<T>(IEnumerable<T> collection, Predicate<T> condition)
    {
        List<T> result = new List<T>();
        foreach (var item in collection)
        {
            if (condition(item))
            {
                result.Add(item);
            }
        }
        return result;
    }

    static void Main()
    {
        var numbers = new List<int> { 123, 1124, 22, 1236, 1233 };
        var specialNumbers = Find(numbers, x => SumDigits(x) == ProductDigits(x));
        Console.WriteLine("Числа, где сумма цифр = произведению: " + string.Join(", ", specialNumbers));

        var strings = new List<string> { "test", "hello&world", "C# & .NET", "example" };
        var withAmpersand = Find(strings, s => s.Contains('&'));
        Console.WriteLine("Строки с '&': " + string.Join(", ", withAmpersand));

        var people = new List<Person>
        {
            new Person { Name = "Anna", City = "Moscow" },
            new Person { Name = "", City = "Kazan" },
            new Person { Name = "Ivan", City = null }
        };

        var validPeople = Find(people, obj => AllStringFieldsFilled(obj));
        Console.WriteLine("Объекты с заполненными строковыми полями:");
        foreach (var person in validPeople)
        {
            Console.WriteLine($"{person.Name}, {person.City}");
        }
    }


    static int SumDigits(int number) =>
        number.ToString().Sum(c => c - '0');

    static int ProductDigits(int number)
    {
        int product = 1;
        foreach (char c in number.ToString())
        {
            product *= c - '0';
        }
        return product;
    }

    static bool AllStringFieldsFilled<T>(T obj)
    {
        foreach (var prop in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (prop.PropertyType == typeof(string))
            {
                var value = (string)prop.GetValue(obj);
                if (string.IsNullOrWhiteSpace(value))
                    return false;
            }
        }
        return true;
    }
}


class Person
{
    public string Name { get; set; }
    public string City { get; set; }
}
