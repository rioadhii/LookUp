using LookUp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LookUp.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    
}