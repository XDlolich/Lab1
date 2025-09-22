using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Logic
    {

        private List<Migrant> MigrantList;
        private List<string> Countries;
        private int LastID;

        /// <summary>
        /// Конуструктор объекта логики системы.
        /// </summary>
        public Logic()
        {
            Countries = new List<string>() { "Бурундия", "Крокожия", "Талмаместан", "Пармезания", "Гачистан" };
            MigrantList = GenerateRandomMigrantList(10);
            LastID = 0;
        }

        /// <summary>
        /// Добавление в систему новой записи о мигранте.
        /// </summary>
        /// <param name="Name">Имя</param>
        /// <param name="CountryOfOrigin">Страна происхождения</param>
        /// <param name="Description">Описание</param>
        /// <param name="Birthday">Дата рождения</param>
        /// <param name="DayOfMigration">Дата миграции</param>
        /// <param name="HasCriminalRecord">Отметка о судимости</param>
        /// <exception cref="ArgumentException">Ввод даты рождения после даты миграции.</exception>
        public void AddNewMigrant(string Name, string CountryOfOrigin, string Description, DateTime Birthday, DateTime DayOfMigration, bool HasCriminalRecord)
        {
            if (Birthday > DayOfMigration)
                throw new ArgumentException("Дата рождения не может быть позже даты миграции!");
            MigrantList.Add(new Migrant(Name, CountryOfOrigin, Description, Birthday, DayOfMigration, HasCriminalRecord,++LastID));
        }

        /// <summary>
        /// Метод добавления новой страны в коллекцию стран.
        /// </summary>
        /// <param name="NameOfNewCountry">Название добавляемой страны</param>
        public void AddNewCountry(string NameOfNewCountry)
        {
            Countries.Add(NameOfNewCountry);
        }

        /// <summary>
        /// Удаление записи о мигранте.
        /// </summary>
        /// <param name="ID">ID мигранта</param>
        public void DeleteMigrant(int ID)
        {
            var migrant = GetMigrantById(ID);
            if (migrant != null)
                MigrantList.Remove(migrant);
        }

        /// <summary>
        /// Метод получения мигранта по его ID.
        /// </summary>
        /// <param name="ID">ID мигранта в системе.</param>
        /// <returns>Экземпляр класса Migrant</returns>
        public Migrant GetMigrantById(int ID)
        {
            return MigrantList.FirstOrDefault(m => m.Id == ID);
        }

        /// <summary>
        /// Метод получения списка мигрантов с судимостями.
        /// </summary>
        /// <returns>Коллекция объетов класса Migrant со значением truе поля HasCriminalRecord</returns>
        public List<Migrant> GetMigrantsWithCriminalRecord()
        {
            return MigrantList.Where(m => m.HasCriminalRecord).ToList();
        }

        /// <summary>
        /// Метод получения массива, отсортированного по времени, прошедшего с момента миграции.
        /// </summary>
        /// <returns>Коллекция объектов класса Migrant</returns>
        public List<Migrant> GetMigrantsByDurationOfStay()
        {
            return MigrantList
                .OrderByDescending(m => (DateTime.Now - m.DayOfMigration).TotalDays)
                .ToList();
        }

        /// <summary>
        /// Метод для получения коллекции стран из системы.
        /// </summary>
        /// <returns>Коллекция строк.</returns>
        public List<string> GetCountries() { return Countries; }

        /// <summary>
        /// Метод получения всей коллекции мигрантов.
        /// </summary>
        /// <returns>Коллекция мигрантов.</returns>
        public IEnumerable<Migrant> GetMigrantList()
        {
            return MigrantList;
        }
        
        /// <summary>
        /// Метод редактирования записи о мигранте в системе.
        /// </summary>
        /// <param name="EditedMigrant">Отредактированная запись о мигранте.</param>
        public void EditMigrant(Migrant EditedMigrant)
        {
            Migrant migrant = GetMigrantById(EditedMigrant.Id);
            if (migrant != null)
            {
                migrant.Name = EditedMigrant.Name;
                migrant.Description = EditedMigrant.Description;
                migrant.Birthday = EditedMigrant.Birthday;
                migrant.DayOfMigration = EditedMigrant.DayOfMigration;
                migrant.HasCriminalRecord = EditedMigrant.HasCriminalRecord;
            }
        }

        /// <summary>
        /// Генерация рандомной коллекции мигрантов.
        /// </summary>
        /// <param name="count">Необходимое для генерации число записей.</param>
        /// <returns>Коллекция объектов Migrant.</returns>
        private List<Migrant> GenerateRandomMigrantList(int count)
        {
            bool hasCriminalRecord;
            Random rnd = new Random();
            List<Migrant> GeneratingMigrantList = new List<Migrant>();
            string[] firstNames = { "Ахмад", "Омар", "Али", "Хасан", "Юсеф", "Халид", "Мухаммед", "Фейсал" };
            string[] lastNames = { "Аль-Фарси", "Аль-Масри", "Аль-Хусейн", "Аль-Карим", "Аль-Шариф", "Аль-Рашид", "Аль-Саид" };
            string description = "Описание не добавлялось.";

            for (int i = 0; i < count; i++)
            {
                string name = $"{firstNames[rnd.Next(firstNames.Length)]} {lastNames[rnd.Next(lastNames.Length)]}";

                DateTime birthday = new DateTime(rnd.Next(1960, 2025), rnd.Next(1, 13), rnd.Next(1, 28));

                DateTime migrationDate = new DateTime(rnd.Next(birthday.Year, DateTime.Now.Year), rnd.Next(1, 13), rnd.Next(1,28));

                if (DateTime.Now.Year - birthday.Year >= 14)
                {
                    hasCriminalRecord = rnd.NextDouble() <= 0.3;
                }
                else
                {
                    hasCriminalRecord = false;
                }

                GeneratingMigrantList.Add(new Migrant(name, Countries[rnd.Next(5)], description, birthday, migrationDate, hasCriminalRecord, ++LastID));
            }
            return GeneratingMigrantList;
        }
    }
}


