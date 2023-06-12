﻿using System.Linq.Expressions;

namespace PredictionBot_DataManagement_Infrastructure.Database.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        IEnumerable<T> GetAll();

        T GetById(int id);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}