using System;

namespace Model
{
    public class Migrant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DayOfMigration { get; set; }
        public bool HasCriminalRecord { get; set; }
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// Конструктор экземпляра класса мигрант.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="сountryOfOrigin">Страна происхождения</param>
        /// <param name="description">Описание</param>
        /// <param name="birthday">Дата рождения</param>
        /// <param name="dayOfMigration">Дата миграции</param>
        /// <param name="hasCriminalRecord">Отметка о судимости</param>
        /// <param name="ID">ID для работы системы</param>
        public Migrant(string name, string сountryOfOrigin, string description, DateTime birthday, DateTime dayOfMigration, bool hasCriminalRecord,int ID=0)
        {
            Id = ID;
            Name = name;
            Description = description;
            Birthday = birthday;
            DayOfMigration = dayOfMigration;
            HasCriminalRecord = hasCriminalRecord;
            CountryOfOrigin = сountryOfOrigin;
        }
    }   
}


