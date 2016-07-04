using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;

namespace CarsCollectors.Application
{
    public class AppTipoVeiculoService : AppBaseService<TipoVeiculo>, IAppTipoVeiculoService
    {
        private readonly ITipoVeiculoService _tipoVeiculoService;

        public AppTipoVeiculoService(ITipoVeiculoService tipoVeiculoService) : base(tipoVeiculoService)
        {
            _tipoVeiculoService = tipoVeiculoService;
        }
    }
}
