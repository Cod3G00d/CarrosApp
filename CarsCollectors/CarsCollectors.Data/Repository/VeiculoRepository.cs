﻿using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Repositories;
using CarsCollectors.Data.Context;

namespace CarsCollectors.Data.Repository
{
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        public VeiculoRepository(CarsCollectorsContext context) : base(context)
        {
        }
    }
}