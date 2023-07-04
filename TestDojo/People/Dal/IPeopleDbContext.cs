using System.Data.Entity;

#nullable disable

namespace TestDojo.People.Dal
{
    public interface IPeopleDbContext
    {
        DbSet<Person> People { get; }
        Task<int> SaveChangesAsync();
    }
}
