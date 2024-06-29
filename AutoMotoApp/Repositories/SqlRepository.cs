namespace AutoMotoApp.Repositories;

using Microsoft.EntityFrameworkCore;
using AutoMotoApp.Entities;

public class SqlRepository
{
    private readonly DbContext _dbContext;
    private readonly DbSet<Employee> _dbSet;

    public SqlRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<Employee>();
    }

  




    public Employee? GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public void Add(Employee item)
    {
        _dbSet.Add(item);
    }

    public void Remove(Employee item)
    {
        _dbSet.Remove(item);
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }
}
