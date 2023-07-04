using System.Data.Entity;
using System.Data.Entity.Migrations;
using TestDojo.People.Dal;

namespace TestDojo.People
{
    public class PeopleService
    {
        private readonly IPeopleDbContext _peopleDbContext;

        public PeopleService(IPeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }

        public Person[] GetAllPeople()
        {
            return _peopleDbContext.People.ToArray();
        }

        public async Task<Person[]> GetAllPeopleAsync()
        {
            return await _peopleDbContext.People.ToArrayAsync();
        }

        public async void AddPersonAsync(Person person)
        {
            _peopleDbContext.People.Add(person);
            await _peopleDbContext.SaveChangesAsync();
        }

        public Person GetPerson(int id)
        {
            return _peopleDbContext.People.FirstOrDefault(p => p.Id == id);
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            return await _peopleDbContext.People.FirstOrDefaultAsync(p => p.Id == id);
        }

        public Person GetPersonNoTracking(int id)
        {
            return _peopleDbContext.People.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        public async Task<Person> GetPersonNoTrackingAsync(int id)
        {
            return await _peopleDbContext.People.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async void RemovePersonAsync(Person person)
        {
            _peopleDbContext.People.Remove(person);
            await _peopleDbContext.SaveChangesAsync();
        }

        public async Task AddOrUpdatePerson(Person person)
        {
            _peopleDbContext.People.AddOrUpdate(person);
            await _peopleDbContext.SaveChangesAsync();
        }
    }
}
