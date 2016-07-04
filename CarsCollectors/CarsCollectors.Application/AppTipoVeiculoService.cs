using System.Collections.Generic;
using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;
using System.Linq;

namespace CarsCollectors.Application
{
    public class AppTipoVeiculoService : AppBaseService<TipoVeiculo>, IAppTipoVeiculoService
    {
        private readonly ITipoVeiculoService _tipoVeiculoService;

        public AppTipoVeiculoService(ITipoVeiculoService tipoVeiculoService) : base(tipoVeiculoService)
        {
            _tipoVeiculoService = tipoVeiculoService;
        }

        public IEnumerable<TipoVeiculo> GetAll()
        {
            return _tipoVeiculoService.GetAll().ToList();
        }
    }
}
