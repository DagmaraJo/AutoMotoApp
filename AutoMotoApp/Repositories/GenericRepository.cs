﻿namespace AutoMotoApp.Repositories
{    //this class is no longer needed - rubbish !
    using AutoMotoApp.Entities;
    
    public class GenericRepository<TEntity, TKey> 
        where TEntity : class, IEntity, new()
        where TKey : struct
    {
        public TKey? Key { get; set; }
        
        protected readonly List<TEntity> _items = new();

        public void Add(TEntity item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public TEntity GetById(int id)
        {
            return _items.Single(item => item.Id == id);
            //return null;
            return default(TEntity);    
        }

        public void Save()
        {
            foreach (var employee in _items)
            {
                Console.WriteLine(employee);
            }
        }

        public TEntity CreateNewItem(TEntity item)
        {
            return new TEntity();
        }

        public void Remove(TEntity item)
        {
            _items.Remove(item);
        }
    }
}
