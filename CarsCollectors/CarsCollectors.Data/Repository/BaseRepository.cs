using CarsCollectors.Domain.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using CarsCollectors.Data.Context;
using System.Data.Entity;

namespace CarsCollectors.Data.Repository
{
    public abstract class BaseRepository<TEntity> :
        IDisposable,
        IBaseRepository<TEntity> where TEntity : class
    {
        protected CarsCollectorsContext db;
        protected BaseRepository(CarsCollectorsContext context)
        {
            if (context == null) throw new ArgumentNullException($"O contexto: {nameof(context)} nao pode ser nulo.");
            db = context;
        }
        public void Add(TEntity TEntity)
        {
            db.Set<TEntity>().Add(TEntity);
        }

        public void Dispose()
        {
            if (db != null)
                db.Dispose();
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return db.Set<TEntity>().Where(predicate);
        }

        public void Remove(TEntity TEntity)
        {
            db.Entry(TEntity).State = EntityState.Deleted;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(TEntity TEntity)
        {
            db.Entry(TEntity).State = EntityState.Modified;
        }
    }
}
