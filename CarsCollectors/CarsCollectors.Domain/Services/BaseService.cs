using CarsCollectors.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CarsCollectors.Domain.Interfaces.Repositories;

namespace CarsCollectors.Domain.Services
{
    public class BaseService<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public void Add(TEntity TEntity)
        {
            _repository.Add(TEntity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.FindBy(predicate);
        }

        public void Remove(TEntity TEntity)
        {
            _repository.Remove(TEntity);
        }

        public void Save()
        {
            _repository.Save();
        }

        public void Update(TEntity TEntity)
        {
            _repository.Update(TEntity);
        }
    }
}
