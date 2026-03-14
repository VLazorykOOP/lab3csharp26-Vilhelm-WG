using Lab3CSharp.task_2;
namespace Lab3CSharp;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Lab 1 - меню");
            Console.WriteLine("2 - Task 2 (перевірка парності)");
            Console.WriteLine("1 - Task 1 (відстань між точками)");
            Console.WriteLine("0 - Вихід");
            Console.Write("Ваш вибір: ");

            string? choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "2":
                        // Створюємо масив базового класу
                        Employee[] staff = new Employee[]
                        {
                            new Engineer("Іван", 35, "Програміст"),
                            new Worker("Петро", 25, 3),
                            new Admin("Сидоренко", 45, "Директор"),
                            new Worker("Василь", 30, 5),
                            new Engineer("Кузьма", 28, "Електрик")
                        };

                        Console.WriteLine("--- Співробітники, впорядковані за типом ---");
    
                        // Сортування за іменем класу
                        var sortedStaff = staff.OrderBy(e => e.GetType().Name);

                        foreach (var emp in sortedStaff)
                        {
                            emp.Show(); // Викличе потрібний метод залежно від реального типу об'єкта
                        }
                    break;

                case "1":
                {
                        task_1_Rectangle[] rects = new task_1_Rectangle[]
                        {
                            new task_1_Rectangle(5, 5, 2),
                            new task_1_Rectangle(10, 2, 1),
                            new task_1_Rectangle(4, 4, 1),
                            new task_1_Rectangle(3, 8, 3)
                        };

                        // 1. Визначення кількості квадратів
                        int squareCount = rects.Count(r => r.IsSquare());
                        Console.WriteLine($"--- Кількість квадратів: {squareCount} ---\n");

                        // 2. Впорядкування за кольорами
                        Console.WriteLine("Впорядковано за КОЛЬОРОМ:");
                        var byColor = rects.OrderBy(r => r.C);
                        PrintCollection(byColor);

                        // 3. Впорядкування за площею
                        Console.WriteLine("\nВпорядковано за ПЛОЩЕЮ:");
                        var byArea = rects.OrderBy(r => r.Area());
                        PrintCollection(byArea);

                        // 4. Впорядкування за периметром
                        Console.WriteLine("\nВпорядковано за ПЕРИМЕТРОМ:");
                        var byPerimeter = rects.OrderBy(r => r.Perimetr());
                        PrintCollection(byPerimeter);

                        break;
                }

                case "0":
                    return;

                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }
    static void PrintCollection(IEnumerable<task_1_Rectangle> collection)
    {
        foreach (var r in collection)
        {
            Console.WriteLine($"Колір: {r.C, -3} | Площа: {r.Area(), -5} | Периметр: {r.Perimetr(), -5} | Квадрат: {r.IsSquare()}");
        }
    }
}