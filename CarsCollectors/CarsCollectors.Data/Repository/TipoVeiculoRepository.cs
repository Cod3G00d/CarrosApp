using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Repositories;
using CarsCollectors.Data.Context;

namespace CarsCollectors.Data.Repository
{
    public class TipoVeiculoRepository : BaseRepository<TipoVeiculo>, ITipoVeiculoRepository
    {
        public TipoVeiculoRepository(CarsCollectorsContext context) : base(context)
        {
        }
    }
}
