using System.Linq;
using CarsCollectors.Domain.Entities;

namespace CarsCollectors.Domain.Interfaces.Repositories
{
    public interface IVeiculoRepository : IBaseRepository<Veiculo>
    {
        IQueryable<Veiculo> GetAll();
    }
}
