using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Repositories;
using CarsCollectors.Data.Context;
using System;
using System.Linq;

namespace CarsCollectors.Data.Repository
{
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(CarsCollectorsContext context) : base(context)
        {
        }

        public IQueryable<Veiculo> GetAll()
        {
            return db.Veiculos.AsQueryable();
        }
    }
}
