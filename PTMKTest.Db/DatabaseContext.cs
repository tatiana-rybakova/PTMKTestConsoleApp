using Microsoft.EntityFrameworkCore;

namespace PTMKTest.Db
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=testDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            //Обозначение индекса для ускорения поиска по выбранным столбцам
            modelBuilder.Entity<Person>().HasIndex(p => new { p.Name, p.Sex }).HasDatabaseName("SearchIndex");
        }
    }
}

