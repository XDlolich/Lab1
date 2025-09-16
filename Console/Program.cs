using System.Reflection;
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
        /// <param name="logic">Экземпляр логики модели.</param>
        static void MainMenu(Logic logic)
        {
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();
                var migrants = logic.GetMigrantList().ToList();
                Console.WriteLine("Система \"Мигрант ID\" (стрелки для переключения по списку, Enter - действия, A - добавить, F - фильтры, Esc - выход):\n");

                for (int i = 0; i < migrants.Count; i++)
                {
                    if (i == selectedIndex)
                        Console.BackgroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine($"{i + 1}. {migrants[i].Name} ({migrants[i].Birthday.Year} г.р.)");
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

                    case ConsoleKey.F:
                        ShowFiltersMenu(logic);
                        break;

                    case ConsoleKey.Escape:
                        return; 
                }
            }
        }

        /// <summary>
        /// Метод работы меню фильтров.
        /// </summary>
        /// <param name="logic">Экземпляр логики модели.</param>
        static void ShowFiltersMenu(Logic logic)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню фильтров:");
                Console.WriteLine("1 - Показать только судимых");
                Console.WriteLine("2 - Показать по времени пребывания (долгие в начале)");
                Console.WriteLine("0 - Назад");

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                {
                    var criminals = logic.GetMigrantsWithCriminalRecord().ToList();
                    ShowFilteredList(criminals, "Список судимых:");
                    break;
                }
                else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                {
                    var sortedByDuration = logic.GetMigrantsByDurationOfStay().ToList();
                    ShowFilteredList(sortedByDuration, "Список по длительности пребывания:");
                    break;
                }
                else if (key == ConsoleKey.D0 || key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Показ объектов отфильтрованной коллекции.
        /// </summary>
        /// <param name="migrants"></param>
        /// <param name="header"></param>
        static void ShowFilteredList(List<Migrant> migrants, string header)
        {
            Console.Clear();
            Console.WriteLine(header + "\n");

            for (int i = 0; i < migrants.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {migrants[i].Name} ({migrants[i].Birthday.Year} г.р.)");
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Метод работы чтения записи.
        /// </summary>
        /// <param name="logic">Экзмепляр логики модели.</param>
        /// <param name="migrant">Объект для чтения.</param>
        static void ShowMigrantMenu(Logic logic, Migrant migrant)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Имя: {migrant.Name}");
                Console.WriteLine($"Описание: {migrant.Description}");
                Console.WriteLine($"Дата рождения: {migrant.Birthday:dd.MM.yyyy}");
                Console.WriteLine($"Дата миграции: {migrant.DayOfMigration:dd.MM.yyyy}");
                Console.WriteLine($"Судим: {(migrant.HasCriminalRecord ? "Да" : "Нет")}\n");

                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Редактировать");
                Console.WriteLine("2 - Удалить");
                Console.WriteLine("0 - Назад");

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
        /// Метод работы редактирования мигранта в консоли.
        /// </summary>
        /// <param name="logic">Экземпляр логики модели.</param>
        /// <param name="migrant">Объект для редактирования.</param>
        static void EditMigrant(Logic logic, Migrant migrant)
        {
            string name;
            string desc;
            DateTime birthday;
            DateTime migration;
            bool criminal;
            Migrant EditedMigrant = migrant;

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

            EditedMigrant.Name = name;
            EditedMigrant.Birthday = birthday;
            EditedMigrant.Description = desc;
            EditedMigrant.DayOfMigration = migration;
            EditedMigrant.HasCriminalRecord = criminal;
            logic.EditMigrant(EditedMigrant);

            Console.Clear();
            Console.WriteLine("Запись о мигранте успешно изменена. Нажмите любую клавишу...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Метод добавления новой записи о мигранте в консоли.
        /// </summary>
        /// <param name="logic">Экзмепляр логики модели.</param>
        static void AddNewMigrant(Logic logic)
        {
            string name;
            string desc;
            DateTime birthday;
            DateTime migration;
            bool criminal;

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

            logic.AddNewMigrant(name, desc, birthday, migration, criminal);
            Console.Clear();
            Console.WriteLine("Мигрант успешно добавлен. Нажмите любую клавишу...");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Метод консольного изменения даты рождения в записи.
        /// </summary>
        /// <param name="birthday">Выходной параметр даты рождения.</param>
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
        /// Метод консольного изменения даты миграции.
        /// </summary>
        /// <param name="birthday">Дата рождения объекта.</param>
        /// <param name="migration">Выходная дата миграции объекта.</param>
        static void EditDateOfMigration(DateTime birthday, out DateTime migration)
        {
            while (true)
            {
                Console.Write("Новая дата миграции (дд.мм.гггг): ");
                if (DateTime.TryParse(Console.ReadLine(), out migration))
                {
                    if (birthday <= migration)
                        break;
                    Console.Clear();
                    Console.WriteLine("Дата рождения не может быть позже даты миграции. Попробуйте снова.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Некорректная дата. Попробуйте снова.");
                }
            }
        }

        /// <summary>
        /// Метод ввода/изменения поля о судимости.
        /// </summary>
        /// <param name="criminal">Отметка о судимости.</param>
        static void CheckCriminal(out bool criminal)
        {
            while (true)
            {
                Console.Write("Есть судимость? (true/false): ");
                if (bool.TryParse(Console.ReadLine(), out criminal))
                    break;
                Console.Clear();
                Console.WriteLine("Введите 'true' или 'false'. Попробуйте снова.");
            }
        }

        /// <summary>
        /// Метод редактирования/добавления описания.
        /// </summary>
        /// <param name="desc">Строка описания</param>
        static void EditDesc(out string desc)
        {
            do
            {
                Console.Write("Новое описание: ");
                desc = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(desc))
                    Console.Clear();
                Console.WriteLine("Описание не может быть пустым. Попробуйте снова.");
            } while (string.IsNullOrWhiteSpace(desc));
        }

        /// <summary>
        /// Метод добавления/редактирования имени.
        /// </summary>
        /// <param name="name">Строка имени</param>
        static void EditName(out string name)
        {
            do
            {
                Console.Write("Новое имя: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    Console.Clear();
                Console.WriteLine("Имя не может быть пустым. Попробуйте снова.");
            } while (string.IsNullOrWhiteSpace(name));
        }
    }
}
    

