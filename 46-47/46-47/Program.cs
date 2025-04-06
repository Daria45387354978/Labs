public struct CAR
{
    public string LicensePlate;
    public string Make;
    public DateTime ReleaseDate;
    public int Mileage;

    public CAR(string licensePlate, string make, DateTime releaseDate, int mileage)
    {
        LicensePlate = licensePlate;
        Make = make;
        ReleaseDate = releaseDate;
        Mileage = mileage;
    }

    public override string ToString()
    {
        return $"{LicensePlate}, {Make}, Дата выпуска: {ReleaseDate.ToShortDateString()}, Пробег: {Mileage}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество автомобилей: ");
        int n = int.Parse(Console.ReadLine());
        CAR[] cars = new CAR[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nВведите данные для автомобиля {i + 1}:");
            Console.Write("Гос. номер: ");
            string licensePlate = Console.ReadLine();
            Console.Write("Марка: ");
            string make = Console.ReadLine();
            Console.Write("Дата выпуска (ГГГГ-ММ-ДД): ");
            DateTime releaseDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Пробег: ");
            int mileage = int.Parse(Console.ReadLine());

            cars[i] = new CAR(licensePlate, make, releaseDate, mileage);
        }
        Console.WriteLine("\nПоиск автомобилей:");
        Console.Write("Введите год выпуска для поиска (не ранее): ");
        int searchYear = int.Parse(Console.ReadLine());
        Console.Write("Введите максимальный пробег для поиска: ");
        int searchMileage = int.Parse(Console.ReadLine());

        var filteredCars = cars.Where(c => c.ReleaseDate.Year >= searchYear && c.Mileage < searchMileage).ToArray();

        Console.WriteLine($"\nНайденные автомобили (Год: >= {searchYear}, Пробег: < {searchMileage}):");
        foreach (var car in filteredCars)
        {
            Console.WriteLine(car);
        }
        Console.WriteLine("\nСортировка автомобилей по марке:");
        var sortedCars = cars.OrderBy(c => c.Make).ToArray();

        Console.WriteLine("Отсортированные автомобили:");
        foreach (var car in sortedCars)
        {
            Console.WriteLine(car);
        }
    }
}
