using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приветствие
            Console.WriteLine("Привет!");
            Console.WriteLine("ФИО: Коновалова Алиса Александровна");
            Console.WriteLine("Группа: ИСП-242");
            Console.WriteLine($"Дата и время: {DateTime.Now}");

            // Меню
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1 — Показать ФИО");
                Console.WriteLine("2 — Показать группу");
                Console.WriteLine("3 — Показать дату");
                Console.WriteLine("4 — Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                // Обработка выбора
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("ФИО: Коновалова Алиса Александровна");
                        break;
                    case "2":
                        Console.WriteLine("Группа: ИСП-242");
                        break;
                    case "3":
                        Console.WriteLine($"Дата и время: {DateTime.Now}");
                        break;
                    case "4":
                        Console.WriteLine("Выход...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}