using CarsCollectors.Domain.Entities;
using System.Linq;

namespace CarsCollectors.Domain.Interfaces.Services
{
    public interface IFabricanteService : IBaseService<Fabricante>
    {
        IQueryable<Fabricante> GetAll();
    }
}
