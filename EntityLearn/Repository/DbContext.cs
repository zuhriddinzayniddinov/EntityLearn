using Microsoft.EntityFrameworkCore;

namespace EntityLearn.Repository;

internal class PersonDbContext : DbContext
{
    public DbSet<Person> persons { get; set; }
    public DbSet<Adress> adress { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=Testered;Integrated Security=true;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonConfiguration());
        modelBuilder.ApplyConfiguration(new AdressConfiguration());
    }
}
