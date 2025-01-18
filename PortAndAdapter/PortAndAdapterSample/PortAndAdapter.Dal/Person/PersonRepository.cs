using PortAndAdapter.Domain.Interface;

namespace PortAndAdapter.Dal.Person;

public class PersonRepository : IPersonRepository
{
    private readonly PortAndAdapterDbContext _context;

    public PersonRepository(PortAndAdapterDbContext context)
    {
        _context = context;
    }
    public Domain.Person Add(Domain.Person person)
    {
        throw new NotImplementedException();
    }

    public Domain.Person Update(Domain.Person person)
    {
        throw new NotImplementedException();
    }

    public Domain.Person Get(int id)
    {
        return _context.People.Single(x => x.Id == id);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}