﻿namespace AutoMotoApp.Repositories
{
    using AutoMotoApp.Entities;
    
    public class GenericRepository<T> where T : EntityBase
    {
        private readonly List<T> _items = new();

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var employee in _items)
            {
                Console.WriteLine(employee);
            }
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
    }
}