using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarsCollectors.Application.Interfaces
{
    public interface IAppBaseService<TEntity> where TEntity : class
    {
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity TEntity);
        void Update(TEntity TEntity);
        void Remove(TEntity TEntity);
        void Save();
        void Dispose();
    }
}
