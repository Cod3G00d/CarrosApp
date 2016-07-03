using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces;
using CarsCollectors.Data.Context;

namespace CarsCollectors.Data.Repository
{
    public class FabricanteRepository : BaseRepository<Fabricante>, IFabricanteRepository
    {
        public FabricanteRepository(CarsCollectorsContext context) : base(context)
        {
        }
    }
}
