using PortAndAdapter.Domain.Interface;

namespace PortAndAdapter.ApplicationService.Person;

public class PersonServices
{
    private readonly IPersonRepository _personRepository;

    public PersonServices(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public Domain.Person GetPerson(int personId)
    {
        var person = _personRepository.Get(personId);

        if (person == null)
            throw new ArgumentNullException("There is no person with id " + personId);

        return person;
    }
}