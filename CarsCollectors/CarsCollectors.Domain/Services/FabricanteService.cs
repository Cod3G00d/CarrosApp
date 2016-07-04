using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;
using CarsCollectors.Domain.Interfaces.Repositories;
using System.Linq;

namespace CarsCollectors.Domain.Services
{
    public class FabricanteService : BaseService<Fabricante>, IFabricanteService
    {
        private readonly IFabricanteRepository _repository;
        public FabricanteService(IFabricanteRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IQueryable<Fabricante> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
