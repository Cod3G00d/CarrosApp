
using System;
using System.Collections.Generic;
using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using CarsCollectors.Domain.Interfaces.Services;

namespace CarsCollectors.Application
{
    public class AppVeiculoService : AppBaseService<Veiculo>, IAppVeiculoService
    {
        private readonly IVeiculoService _veiculoService;
        public AppVeiculoService(IVeiculoService veiculoService) : base(veiculoService)
        {
            _veiculoService = veiculoService;
        }

        public IEnumerable<Veiculo> GetAll()
        {
            return _veiculoService.GetAll();
        }
    }
}
