using Microsoft.EntityFrameworkCore;
using PTMKTest.Db;

namespace PTMKTestConsoleApp
{
    public class PersonViewModel
    {        
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return (int.Parse(DateTime.Today.ToString("yyyyMMdd")) - int.Parse(Birthday.Date.ToString("yyyyMMdd"))) / 10000;
            }
        }
        public string Sex { get; set; }

        public PersonViewModel() { }
        public PersonViewModel(string name, DateTime birthday, string sex)
        {
            Name = name;
            Birthday = birthday;
            Sex = sex;
        }        
    }
}
