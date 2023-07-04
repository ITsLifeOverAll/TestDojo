# Description of the DBTestUtils module

These files are extracted from Sina Iravanian's blog post: 

[Mock Entity Framework DbSet with NSubstitute](http://sinairv.github.io/blog/2015/10/04/mock-entity-framework-dbset-with-nsubstitute/).

Original source code is available on [GitHub](https://github.com/sinairv/MockEfDbSetWithNSubstitute)

I modified the code in file TestDbAsyncEnumerator.cs and commented out the code in Dispose(). 

This modification is necessary to make the code workable. 

```csharp
public async Task<Person?[]> GetAllPeopleAsync()
{
    return await _peopleDbContext.People.OrderBy(x => x.FirstName).ToArrayAsync();
}
```

But, this modification will make mock DbSets could not be enumerated more than once.
