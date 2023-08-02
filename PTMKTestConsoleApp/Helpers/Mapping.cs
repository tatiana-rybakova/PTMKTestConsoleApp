using PTMKTest.Db;

namespace PTMKTestConsoleApp.Helpers
{
    public static class Mapping
    {
        public static List<Person> ToPersons(this List<PersonViewModel> persons)
        {
            var personsDb = new List<Person>();
            foreach (var person in persons)
            {
                personsDb.Add(person.ToPerson());
            }
            return personsDb;
        }
        public static Person ToPerson(this PersonViewModel person)
        {
            return new Person
            {
                Name = person.Name,
                Birthday = person.Birthday,
                Sex = person.Sex,
            };
        }

        public static List<PersonViewModel> ToPersonViewModels(this List<Person> personsDb)
        {
            var persons = new List<PersonViewModel>();
            foreach (var person in personsDb)
            {
                persons.Add(person.ToPersonViewModel());
            }
            return persons;
        }

        public static PersonViewModel ToPersonViewModel(this Person person)
        {
            return new PersonViewModel
            {
                Name = person.Name,
                Birthday = person.Birthday,
                Sex = person.Sex,
            };
        }
    }
}
