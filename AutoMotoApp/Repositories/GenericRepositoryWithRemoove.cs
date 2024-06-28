namespace AutoMotoApp.Repositories;

using AutoMotoApp.Entities;

public class GenericRepositoryWithRemoove<T, TKey> : GenericRepository<T, TKey> where T : IEntity
{
    public void Remoove(T item)
    {
        _items.Remove(item);
    }
}
