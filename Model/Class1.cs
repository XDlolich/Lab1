using System.Xml.Linq;

namespace Laba1
{
    public class Logic
    {
        private List<Migrant> MigrantList;
        public void AddNewMigrant(string Name, string Description, DateTime Birthday, DateTime DayOfMigration, bool HasCriminalRecord)
        {
            MigrantList.Add(new Migrant(MigrantList.Count(), Name, Description, Birthday, DayOfMigration, HasCriminalRecord));
        }

        public bool DeleteMigrant(int ID)
        {
            if (MigrantList.Count >= (ID))
            {
                MigrantList.RemoveAt(ID + 1);
                return true;
            }
            else
                return false;
        }

        public Migrant GetMigrantById(int ID) 
        {
            return MigrantList.FirstOrDefault(m => m.Id == ID);
        }

        public IEnumerable<Migrant> GetMigrantList()    
        {
            return MigrantList;   
        }
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
    }

    public class Migrant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DayOfMigration { get; set; }
        public bool HasCriminalRecord { get; set; }

        public Migrant(int ListCount, string name, string description, DateTime birthday, DateTime dayOfMigration, bool hasCriminalRecord)
        {
            Id= ListCount + 1;
            Name = name;
            Description = description;
            Birthday = birthday;
            DayOfMigration = dayOfMigration;
            HasCriminalRecord = hasCriminalRecord;
        }
    }
}
