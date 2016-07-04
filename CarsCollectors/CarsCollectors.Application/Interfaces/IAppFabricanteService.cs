using CarsCollectors.Domain.Entities;
using System.Collections.Generic;

namespace CarsCollectors.Application.Interfaces
{
    public interface IAppFabricanteService : IAppBaseService<Fabricante>
    {
        IEnumerable<Fabricante> GetAll();
    }
}
