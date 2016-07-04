using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;
using CarsCollectors.Domain.Interfaces.Repositories;
using System.Linq;

namespace CarsCollectors.Domain.Services
{
    public class TipoVeiculoService : BaseService<TipoVeiculo>, ITipoVeiculoService
    {
        private readonly ITipoVeiculoRepository _repository;
        public TipoVeiculoService(ITipoVeiculoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IQueryable<TipoVeiculo> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
