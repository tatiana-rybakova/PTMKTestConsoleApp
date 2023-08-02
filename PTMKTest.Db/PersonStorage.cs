using PTMKTest.Db.Helpers;

namespace PTMKTest.Db
{
    public class PersonStorage : IPersonStorage
    {
        DatabaseContext db = new DatabaseContext();

        public void CreateTable()
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }

        public List<Person> GetAll()
        {
            return db.Persons.ToList();
        }

        public void Add(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
        }

        public List<Person> GetUnique()
        {           
            return db.Persons.MyDistinct2().OrderBy(p => p.Name).ToList();
        }

        public void AddRange(List<Person> newPersons)
        {
            db.Persons.AddRange(newPersons);
            db.SaveChanges();
        }

        public List<Person> SearchByNameAndSex()
        {
            return db.Persons.Where(p => p.Name.StartsWith("F") && p.Sex == "M").ToList();
        }
    }
}
