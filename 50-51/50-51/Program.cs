using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FirstYearStudent
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Patronymic { get; set; }
    public string Group { get; set; }

    public FirstYearStudent(string line)
    {
        string[] parts = line.Split(',');
        if (parts.Length != 5)
        {
            throw new FormatException("Неверный формат строки.");
        }

        LastName = parts[0].Trim();
        FirstName = parts[1].Trim();
        Patronymic = parts[2].Trim();
        Group = parts[3].Trim();

    }

    public class StudentProcessor
    {
        public static void ProcessStudents(string inputFile, string outputGroupsFile, string outputAllFile)
        {
            List<FirstYearStudent> students = new List<FirstYearStudent>();

            try
            {
                string[] lines = File.ReadAllLines(inputFile);
                foreach (string line in lines)
                {
                    try
                    {
                        students.Add(new FirstYearStudent(line));
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Ошибка форматирования строки: {line} - {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
                    }
                }

                var groupCounts = students.GroupBy(s => s.Group)
                                         .ToDictionary(g => g.Key, g => g.Count());

                File.WriteAllText(outputGroupsFile, string.Join(Environment.NewLine, groupCounts.Select(pair => $"{pair.Key}: {pair.Value}")));

                File.WriteAllText(outputAllFile, string.Join(Environment.NewLine, students.Select(s => $"{s.LastName},{s.FirstName},{s.Patronymic},{s.Group},")));

                Console.WriteLine("Результаты успешно записаны.");
                Console.WriteLine("Группы и количество студентов:");
                foreach (var group in groupCounts)
                {
                    Console.WriteLine($"{group.Key}: {group.Value}");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: Файл {inputFile} не найден.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            string inputFile = "students.txt";
            string outputGroupsFile = "groups.txt";
            string outputAllFile = "all_students.txt";
            StudentProcessor.ProcessStudents(inputFile, outputGroupsFile, outputAllFile);
        }
    }

}
