using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;
using CarsCollectors.Domain.Interfaces.Repositories;
using System;
using System.Linq;

namespace CarsCollectors.Domain.Services
{
    public class VeiculoService : BaseService<Veiculo>, IVeiculoService
    {
        private readonly IVeiculoRepository _repository;
        public VeiculoService(IVeiculoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IQueryable<Veiculo> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
