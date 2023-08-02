namespace PTMKTest.Db.Helpers
{
    public class PersonIEqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person firstPerson, Person secondPerson)
        {
            return firstPerson.Name == secondPerson.Name && firstPerson.Birthday == secondPerson.Birthday;
        }

        public int GetHashCode(Person obj)
        {
            return HashCode.Combine(obj.Name, obj.Birthday);
        }     
    }
}
