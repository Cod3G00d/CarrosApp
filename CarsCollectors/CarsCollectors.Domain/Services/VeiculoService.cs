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
    public class VeiculoService : BaseService<Veiculo>, IVeiculoService
    {
        private readonly IVeiculoRepository _repository;
        public VeiculoService(IVeiculoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
