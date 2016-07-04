using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Repositories;
using CarsCollectors.Data.Context;
using System.Linq;

namespace CarsCollectors.Data.Repository
{
    public class TipoVeiculoRepository : BaseRepository<TipoVeiculo>, ITipoVeiculoRepository
    {
        public TipoVeiculoRepository(CarsCollectorsContext context) : base(context)
        {
        }

        public IQueryable<TipoVeiculo> GetAll()
        {
            return db.TiposVeiculo.AsQueryable();
        }
    }
}
