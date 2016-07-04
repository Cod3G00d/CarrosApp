using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsCollectors.Domain.Interfaces.Repositories;

namespace CarsCollectors.Domain.Services
{
    public class FabricanteService : BaseService<Fabricante>, IFabricanteService
    {
        private readonly IFabricanteRepository _repository;
        public FabricanteService(IFabricanteRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
