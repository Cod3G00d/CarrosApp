using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces;
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
