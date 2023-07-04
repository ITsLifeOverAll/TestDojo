using System.Data.Entity;

#nullable disable

namespace TestDojo.People.Dal
{
    public class PeopleDbContext : DbContext, IPeopleDbContext
    {
        public DbSet<Person> People { get; set; }
    }
}
