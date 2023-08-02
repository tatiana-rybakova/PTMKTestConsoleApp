using PTMKTest.Db;

namespace PTMKTestConsoleApp.Helpers
{
    public class Randomizer
    {
        public static List<string[]> randomNames = new List<string[]>()
        {
            new string[] { "Ivanov Artem Vladimirovich", "M" },
            new string[] { "Petrov Aleksandr Ivanovich", "M" },
            new string[] { "Kuzmina Tatiana Vladimirovna", "F" },
            new string[] { "Sidorova Maria Ivanovna", "F" },
            new string[] { "Smirnov Andrey Pavlopich", "M" },
            new string[] { "Ivanova Anna Alexandrovna", "F" },
            new string[] { "Lavrov Egor Sergeevich", "M" },
            new string[] { "Kuznetsova Vera Evgenjevna", "F" },
            new string[] { "Popov Aleksey Viktorovich", "M" },
            new string[] { "Lukina Inna Petrovna", "F" },
        };

        public static List<string[]> randomFNames = new List<string[]>()
        {
            new string[] { "Fedorov Artem Vladimirovich", "M" },
            new string[] { "Frolov Aleksandr Ivanovich", "M" },
            new string[] { "Fedoseev Aleksandr Ivanovich", "M" },
            new string[] { "Filippov Aleksey Viktorovich", "M" },
            new string[] { "Fionov Andrey Pavlopich", "M" },
            new string[] { "Fokin Egor Sergeevich", "M" },
            new string[] { "Fortov Egor Sergeevich", "M" },
            new string[] { "Firsov Artem Vladimirovich", "M" },
            new string[] { "Feklin Aleksey Viktorovich", "M" },
            new string[] { "Fedortsov Andrey Pavlopich", "M" },
        };

        public static List<DateTime> randomBirtdays = new List<DateTime>
        {
            new DateTime(1992, 01, 23),
            new DateTime(2000, 02, 12),
            new DateTime(2001, 03, 16),
            new DateTime(1998, 06, 11),
            new DateTime(1995, 04, 01),
            new DateTime(1994, 07, 18),
            new DateTime(1993, 05, 28),
            new DateTime(1996, 08, 30),
            new DateTime(1997, 11, 04),
            new DateTime(1999, 12, 31)
        };

        private static Random random = new Random();

        public static Person GetRandomPerson(bool isFName)
        {
            var randomNameIndex = random.Next(10);
            var randomBirthdayIndex = random.Next(10);

            string[] randomName;

            if (isFName)
            {
                randomName = randomFNames[randomNameIndex];
            }
            else
            {
                randomName = randomNames[randomNameIndex];
            }

            var randomPerson = new Person();
            randomPerson.Name = randomName[0];
            randomPerson.Sex = randomName[1];
            randomPerson.Birthday = randomBirtdays[randomBirthdayIndex];

            return randomPerson;
        }
    }
}
