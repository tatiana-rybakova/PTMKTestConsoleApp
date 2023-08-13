using PTMKTest.Db;
using PTMKTestConsoleApp.Helpers;
using System.Diagnostics;

namespace PTMKTestConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPersonStorage personStorage = new PersonStorage();            

            switch (args[0])
            {
                case "1":
                    personStorage.CreateTable();
                    Console.WriteLine("Таблица создана");
                    break;

                case "2":
                    var newPerson = new PersonViewModel(args[1], DateTime.Parse(args[2]), args[3]);
                    personStorage.Add(newPerson.ToPerson());

                    Console.WriteLine("Запись добавлена");
                    break;

                case "3":
                    var uniqPersons = personStorage.GetUnique().ToPersonViewModels();

                    foreach (var person in uniqPersons)
                    {
                        Console.WriteLine($"{person.Name} - {person.Birthday.ToLongDateString()} - {person.Sex} - {person.Age}");
                    }
                    break;

                case "4":

                    var newPersons = new List<Person>();

                    for (int i = 0; i < 1000000; i++)
                    {
                        var randomPerson = Randomizer.GetRandomPerson(false);
                        newPersons.Add(randomPerson);
                    }
                    for (int i = 0; i < 100; i++)
                    {
                        var randomPerson = Randomizer.GetRandomPerson(true);
                        newPersons.Add(randomPerson);
                    }
                    personStorage.AddRange(newPersons);
                    Console.WriteLine("Данные добавлены");
                    break;

                case "5":
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    var searchPersons = personStorage.SearchByNameAndSex();

                    stopwatch.Start();
                    Console.WriteLine(stopwatch.ElapsedMilliseconds);
                    break;

                default:
                    Console.WriteLine("Введите значение от 1 до 5");
                    break;
            }

        }

    }
}

