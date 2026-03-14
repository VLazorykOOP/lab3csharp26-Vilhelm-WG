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
            Console.WriteLine("5 - Task 5 (Добуток цілих чисел)");
            Console.WriteLine("4 - Task 4 (Масті)");
            Console.WriteLine("3 - Task 3 (перевірка належності точки)");
            Console.WriteLine("2 - Task 2 (перевірка парності)");
            Console.WriteLine("1 - Task 1 (відстань між точками)");
            Console.WriteLine("0 - Вихід");
            Console.Write("Ваш вибір: ");

            string? choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {

                case "4":
                    Task_4.Run();
                    break;

                case "3":
                    Task_3.Run();
                    break;

                case "2":
                    Task_2.Run();
                    break;

                case "1":
                {
                    task_1_Rectangle[] rects = new task_1_Rectangle[]
                    {
                        new task_1_Rectangle(5, 5, 2),  // Квадрат, колір 2
                        new task_1_Rectangle(10, 2, 1), // Прямокутник, колір 1
                        new task_1_Rectangle(4, 4, 1),  // Квадрат, колір 1
                        new task_1_Rectangle(3, 8, 3)   // Прямокутник, колір 3
                    };
                }
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }
}