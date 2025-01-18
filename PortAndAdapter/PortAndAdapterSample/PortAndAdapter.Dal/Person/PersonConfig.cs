using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PortAndAdapter.Dal.Person;

public class PersonConfig : IEntityTypeConfiguration<Domain.Person>
{
    public void Configure(EntityTypeBuilder<Domain.Person> builder)
    {
        throw new NotImplementedException();
    }
}