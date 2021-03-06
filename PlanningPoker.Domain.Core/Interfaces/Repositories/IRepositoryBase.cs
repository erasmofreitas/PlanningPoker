using System;
using System.Collections.Generic;
using System.Text;

namespace PlanningPoker.Domain.Core.Interfaces.Repositories
{
   public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Dispose();
    }
}
