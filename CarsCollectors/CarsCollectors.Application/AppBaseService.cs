using CarsCollectors.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CarsCollectors.Domain.Interfaces.Services;

namespace CarsCollectors.Application
{
    public class AppBaseService<TEntity> : IDisposable, IAppBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _baseService;
        public AppBaseService(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        public void Add(TEntity TEntity)
        {
            _baseService.Add(TEntity);
        }

        public void Dispose()
        {
            _baseService.Dispose();
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _baseService.FindBy(predicate);
        }

        public void Remove(TEntity TEntity)
        {
            _baseService.Remove(TEntity);
        }

        public void Save()
        {
            _baseService.Save();
        }

        public void Update(TEntity TEntity)
        {
            _baseService.Update(TEntity);
        }
    }
}
