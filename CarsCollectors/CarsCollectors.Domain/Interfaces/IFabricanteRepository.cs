using CarsCollectors.Domain.Entities;
using System.Linq;

namespace CarsCollectors.Domain.Interfaces
{
    public interface IFabricanteRepository : IBaseRepository<Fabricante>
    {
        IQueryable<Fabricante> GetAll();
    }
}
