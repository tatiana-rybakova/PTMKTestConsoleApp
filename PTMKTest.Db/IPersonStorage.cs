namespace PTMKTest.Db
{
    public interface IPersonStorage
    {
        void CreateTable();
        List<Person> GetAll();
        void Add(Person person);
        List<Person> GetUnique();
        void AddRange(List<Person> newPersons);
        List<Person> SearchByNameAndSex();
    }
}
