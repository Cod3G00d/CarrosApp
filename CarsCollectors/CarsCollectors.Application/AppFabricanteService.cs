using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;

namespace CarsCollectors.Application
{
    public class AppFabricanteService : AppBaseService<Fabricante>, IAppFabricanteService
    {
        private readonly IFabricanteService _fabricanteService;
        public AppFabricanteService(IFabricanteService fabricanteService) : base(fabricanteService)
        {
            _fabricanteService = fabricanteService;
        }
    }
}
