namespace PortAndAdapter.Domain.Interface;

public interface IPersonRepository
{
    Person Add(Person person);
    Person Update(Person person);
    Person Get(int id);
    void Delete(int id);
}