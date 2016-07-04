using System.Linq;
using CarsCollectors.Domain.Entities;

namespace CarsCollectors.Domain.Interfaces.Repositories
{
    public interface ITipoVeiculoRepository : IBaseRepository<TipoVeiculo>
    {
        IQueryable<TipoVeiculo> GetAll();
    }
}
