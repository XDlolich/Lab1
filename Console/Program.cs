using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            Console.CursorVisible = true;

            MainMenu(logic);
        }

        /// <summary>
        /// Метод работы консольного меню.
        /// </summary>
        static void MainMenu(Logic logic)
        {
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();
                var migrants = logic.GetMigrantList().ToList();
                Console.WriteLine("Система \"Мигрант ID\"");
                Console.WriteLine("(стрелки для списка, Enter - действия, A - добавить мигранта, C - добавить страну, F - фильтры, Esc - выход):\n");

                for (int i = 0; i < migrants.Count; i++)
                {
                    if (i == selectedIndex)
                        Console.BackgroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine($"{i + 1}. {migrants[i].Name} ({migrants[i].Birthday.Year} г.р.) [{migrants[i].CountryOfOrigin}]");
                    Console.ResetColor();
                }

                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : migrants.Count - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        selectedIndex = (selectedIndex < migrants.Count - 1) ? selectedIndex + 1 : 0;
                        break;

                    case ConsoleKey.Enter:
                        if (migrants.Count > 0)
                            ShowMigrantMenu(logic, migrants[selectedIndex]);
                        break;

                    case ConsoleKey.A:
                        AddNewMigrant(logic);
                        break;

                    case ConsoleKey.C:
                        AddNewCountry(logic);
                        break;

                    case ConsoleKey.F:
                        ShowFiltersMenu(logic);
                        break;

                    case ConsoleKey.Escape:
                        return;
                }
            }
        }

        /// <summary>
        /// Меню фильтров.
        /// </summary>
        static void ShowFiltersMenu(Logic logic)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню фильтров:");
                Console.WriteLine("1 - Показать только судимых");
                Console.WriteLine("2 - Показать по времени пребывания (долгие в начале)");
                Console.WriteLine("0/Esc - Назад");

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                {
                    var criminals = logic.GetMigrantsWithCriminalRecord().ToList();
                    ShowFilteredList(criminals, "Список судимых:");
                }
                else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                {
                    var sortedByDuration = logic.GetMigrantsByDurationOfStay().ToList();
                    ShowFilteredList(sortedByDuration, "Список по длительности пребывания:");
                }
                else if (key == ConsoleKey.D0 || key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Показ отфильтрованной коллекции.
        /// </summary>
        static void ShowFilteredList(List<Migrant> migrants, string header)
        {
            Console.Clear();
            Console.WriteLine(header + "\n");

            for (int i = 0; i < migrants.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {migrants[i].Name} ({migrants[i].Birthday.Year} г.р.) [{migrants[i].CountryOfOrigin}]");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Чтение записи мигранта.
        /// </summary>
        static void ShowMigrantMenu(Logic logic, Migrant migrant)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Имя: {migrant.Name}");
                Console.WriteLine($"Описание: {migrant.Description}");
                Console.WriteLine($"Дата рождения: {migrant.Birthday:dd.MM.yyyy}");
                Console.WriteLine($"Дата миграции: {migrant.DayOfMigration:dd.MM.yyyy}");
                Console.WriteLine($"Судим: {(migrant.HasCriminalRecord ? "Да" : "Нет")}");
                Console.WriteLine($"Страна происхождения: {migrant.CountryOfOrigin}\n");

                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Редактировать");
                Console.WriteLine("2 - Удалить");
                Console.WriteLine("0/Esc - Назад");

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                {
                    EditMigrant(logic, migrant);
                    break;
                }
                else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                {
                    logic.DeleteMigrant(migrant.Id);
                    break;
                }
                else if (key == ConsoleKey.D0 || key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Редактирование мигранта.
        /// </summary>
        static void EditMigrant(Logic logic, Migrant migrant)
        {
            string name = migrant.Name;
            string description = migrant.Description;
            string country = migrant.CountryOfOrigin;
            DateTime birthday = migrant.Birthday;
            DateTime dayOfMigration = migrant.DayOfMigration;
            bool hasCriminalRecord = migrant.HasCriminalRecord;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Редактирование мигранта:");
                Console.WriteLine($"1 - Имя ({name})");
                Console.WriteLine($"2 - Описание ({description})");
                Console.WriteLine($"3 - Дата рождения ({birthday:dd.MM.yyyy})");
                Console.WriteLine($"4 - Дата миграции ({dayOfMigration:dd.MM.yyyy})");
                Console.WriteLine($"5 - Судимость ({(hasCriminalRecord ? "Да" : "Нет")})");
                Console.WriteLine($"6 - Страна ({country})");
                Console.WriteLine("0/Esc - Сохранить и выйти");

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1) EditName(out name);
                else if (key == ConsoleKey.D2) EditDesc(out description);
                else if (key == ConsoleKey.D3) EditBirthday(out birthday);
                else if (key == ConsoleKey.D4) EditDateOfMigration(birthday, out dayOfMigration);
                else if (key == ConsoleKey.D5) CheckCriminal(out hasCriminalRecord);
                else if (key == ConsoleKey.D6) country = SelectCountry(logic);
                else if (key == ConsoleKey.D0 || key == ConsoleKey.Escape)
                {
                    migrant.Name = name;
                    migrant.Description = description;
                    migrant.Birthday = birthday;
                    migrant.DayOfMigration = dayOfMigration;
                    migrant.HasCriminalRecord = hasCriminalRecord;
                    migrant.CountryOfOrigin = country;

                    logic.EditMigrant(migrant);
                    break;
                }
            }
        }

        /// <summary>
        /// Добавление новой записи о мигранте.
        /// </summary>
        static void AddNewMigrant(Logic logic)
        {
            string name;
            string desc;
            DateTime birthday;
            DateTime migration;
            bool criminal;
            string country;

            Console.Clear();
            EditName(out name);

            Console.Clear();
            EditDesc(out desc);

            Console.Clear();
            EditBirthday(out birthday);

            Console.Clear();
            EditDateOfMigration(birthday, out migration);

            Console.Clear();
            CheckCriminal(out criminal);

            Console.Clear();
            country = SelectCountry(logic);

            logic.AddNewMigrant(name, country, desc, birthday, migration, criminal);
            Console.Clear();
            Console.WriteLine("Мигрант успешно добавлен. Нажмите любую клавишу...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Добавление новой страны.
        /// </summary>
        static void AddNewCountry(Logic logic)
        {
            Console.Clear();
            Console.Write("Введите название новой страны: ");
            string newCountry = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newCountry) && newCountry.All(c => !char.IsDigit(c)))
            {
                logic.AddNewCountry(newCountry);
                Console.WriteLine("Страна успешно добавлена!");
            }
            else
            {
                Console.WriteLine("Некорректное название страны!");
            }

            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Изм. или созд. даты рождения.
        /// </summary>
        /// <param name="birthday">Дата рождения</param>
        static void EditBirthday(out DateTime birthday)
        {
            while (true)
            {
                Console.Write("Дата рождения (дд.мм.гггг): ");
                if (DateTime.TryParse(Console.ReadLine(), out birthday))
                    break;
                Console.Clear();
                Console.WriteLine("Некорректная дата. Попробуйте снова.");
            }
        }

        /// <summary>
        /// Изм. или созд. даты миграции.
        /// </summary>
        /// <param name="birthday">Дата рождения</param>
        /// <param name="migration">Дата миграции</param>
        static void EditDateOfMigration(DateTime birthday, out DateTime migration)
        {
            while (true)
            {
                Console.Write("Дата миграции (дд.мм.гггг): ");
                if (DateTime.TryParse(Console.ReadLine(), out migration))
                {
                    if (birthday <= migration)
                        break;
                    Console.Clear();
                    Console.WriteLine("Дата рождения не может быть позже даты миграции.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Некорректная дата. Попробуйте снова.");
                }
            }
        }

        /// <summary>
        /// Метод добавления отмеки о судимости.
        /// </summary>
        /// <param name="criminal">Логическая переменная "судим"</param>
        static void CheckCriminal(out bool criminal)
        {
            while (true)
            {
                Console.Write("Есть судимость? (true/false): ");
                if (bool.TryParse(Console.ReadLine(), out criminal))
                    break;
                Console.Clear();
                Console.WriteLine("Введите 'true' или 'false'.");
            }
        }

        /// <summary>
        /// Доб. или изм. описания мигранта.
        /// </summary>
        /// <param name="desc">Строка описания</param>
        static void EditDesc(out string desc)
        {
            do
            {
                Console.Write("Описание: ");
                desc = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(desc));
        }

        /// <summary>
        /// Добавление или изменение имени.
        /// </summary>
        /// <param name="name">Строка имя</param>
        static void EditName(out string name)
        {
            do
            {
                Console.Write("Имя: ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
        }

        /// <summary>
        /// Выбор страны из списка или добавление новой.
        /// </summary>
        static string SelectCountry(Logic logic)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите страну происхождения:");

                var countries = logic.GetCountries();
                for (int i = 0; i < countries.Count; i++)
                    Console.WriteLine($"{i + 1}. {countries[i]}");

                Console.WriteLine("0 - Добавить новую страну");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    if (choice > 0 && choice <= countries.Count)
                        return countries[choice - 1];
                    else if (choice == 0)
                    {
                        Console.Write("Введите название новой страны: ");
                        string newCountry = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(newCountry) && newCountry.All(c => !char.IsDigit(c)))
                        {
                            logic.AddNewCountry(newCountry);
                            return newCountry;
                        }
                    }
                }
            }
        }
    }
}
