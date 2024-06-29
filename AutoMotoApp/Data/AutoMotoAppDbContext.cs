namespace AutoMotoApp.Data;

using Microsoft.EntityFrameworkCore;
using AutoMotoApp.Entities;

public class AutoMotoAppDbContext : DbContext
{
    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StorageAppDb");
    }
}
