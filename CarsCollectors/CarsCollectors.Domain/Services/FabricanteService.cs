using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;
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
