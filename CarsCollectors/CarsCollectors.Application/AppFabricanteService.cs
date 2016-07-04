using System.Collections.Generic;
using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;
using System.Linq;

namespace CarsCollectors.Application
{
    public class AppFabricanteService : AppBaseService<Fabricante>, IAppFabricanteService
    {
        private readonly IFabricanteService _fabricanteService;
        public AppFabricanteService(IFabricanteService fabricanteService) : base(fabricanteService)
        {
            _fabricanteService = fabricanteService;
        }

        public IEnumerable<Fabricante> GetAll()
        {
            return _fabricanteService.GetAll().OrderBy(f => f.Nome).ToList();
        }
    }
}
