namespace AutoMotoApp.Repositories;

using AutoMotoApp.Entities;

public class GenericRepositoryWithRemoove<TEntity, TKey>
    : GenericRepository<TEntity, TKey> 
    where TEntity : class, IEntity, new()
    where TKey : struct
{
    public void Remoove(TEntity item)
    {
        _items.Remove(item);
    }
}
