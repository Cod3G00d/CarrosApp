using CarsCollectors.Domain.Entities;
using System.Linq;

namespace CarsCollectors.Domain.Interfaces.Repositories
{
    public interface IFabricanteRepository : IBaseRepository<Fabricante>
    {
        IQueryable<Fabricante> GetAll();
    }
}
