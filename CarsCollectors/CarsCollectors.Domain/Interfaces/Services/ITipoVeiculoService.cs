using CarsCollectors.Domain.Entities;
using System.Linq;

namespace CarsCollectors.Domain.Interfaces.Services
{
    public interface ITipoVeiculoService : IBaseService<TipoVeiculo>
    {
        IQueryable<TipoVeiculo> GetAll();
    }
}
