namespace AutoMotoApp.Repositories;

using AutoMotoApp.Entities;

public class GenericRepositoryWithRemoove<T> : GenericRepository<T> where T : IEntity
{
    public void Remoove(T item)
    {
        _items.Remove(item);
    }
}
