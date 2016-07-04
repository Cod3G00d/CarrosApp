using System.Collections.Generic;
using CarsCollectors.Domain.Entities;

namespace CarsCollectors.Application.Interfaces
{
    public interface IAppTipoVeiculoService : IAppBaseService<TipoVeiculo>
    {
        IEnumerable<TipoVeiculo> GetAll();
    }
}
