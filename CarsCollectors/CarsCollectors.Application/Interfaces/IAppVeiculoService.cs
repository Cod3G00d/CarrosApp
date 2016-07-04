using CarsCollectors.Domain.Entities;
using System.Collections.Generic;

namespace CarsCollectors.Application.Interfaces
{
    public interface IAppVeiculoService : IAppBaseService<Veiculo>
    {
        IEnumerable<Veiculo> GetAll();
    }
}
