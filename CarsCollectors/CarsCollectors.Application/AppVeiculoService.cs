
using CarsCollectors.Application.Interfaces;
using CarsCollectors.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsCollectors.Domain.Interfaces.Services;

namespace CarsCollectors.Application
{
    public class AppVeiculoService : AppBaseService<Veiculo>, IAppVeiculoService
    {
        public AppVeiculoService(IVeiculoService veiculoService) : base(veiculoService)
        {
        }
    }
}
