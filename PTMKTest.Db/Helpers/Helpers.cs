namespace PTMKTest.Db.Helpers
{
    public static class Helpers
    {
        public static IEnumerable<Person> MyDistinct2(this IEnumerable<Person> persons)
        {
            return persons.Distinct(new PersonIEqualityComparer());
        }
    }
}
