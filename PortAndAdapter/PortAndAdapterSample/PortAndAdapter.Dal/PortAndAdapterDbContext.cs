using Microsoft.EntityFrameworkCore;
using PortAndAdapter.Domain;

namespace PortAndAdapter.Dal;

public class PortAndAdapterDbContext : DbContext
{
    public DbSet<Domain.Person> People { get; set; }
}