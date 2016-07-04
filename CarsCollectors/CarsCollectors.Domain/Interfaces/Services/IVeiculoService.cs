using System.Collections.Generic;
using CarsCollectors.Domain.Entities;
using System.Linq;

namespace CarsCollectors.Domain.Interfaces.Services
{
    public interface IVeiculoService : IBaseService<Veiculo>
    {
        IQueryable<Veiculo> GetAll();
    }
}
