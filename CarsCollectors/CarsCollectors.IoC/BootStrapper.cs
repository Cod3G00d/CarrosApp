using CarsCollectors.Application;
using CarsCollectors.Application.Interfaces;
using CarsCollectors.Data.Context;
using CarsCollectors.Data.Repository;
using CarsCollectors.Domain.Interfaces.Repositories;
using CarsCollectors.Domain.Interfaces.Services;
using CarsCollectors.Domain.Services;
using SimpleInjector;

namespace CarsCollectors.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            Register(container, ScopedLifestyle.Scoped);
        }

        public static void RegisterServices(Container webapiContainer, ScopedLifestyle defaultScopedLifestyle)
        {
            Register(webapiContainer, defaultScopedLifestyle);
        }

        private static void Register(Container container, ScopedLifestyle defaultScopedLifestyle)
        {
            container.Register<CarsCollectorsContext>(defaultScopedLifestyle);
            container.Register<IFabricanteRepository, FabricanteRepository>(defaultScopedLifestyle);
            container.Register<IFabricanteService, FabricanteService>(defaultScopedLifestyle);
            container.Register<IAppFabricanteService, AppFabricanteService>(defaultScopedLifestyle);

            container.Register<ITipoVeiculoRepository, TipoVeiculoRepository>(defaultScopedLifestyle);
            container.Register<ITipoVeiculoService, TipoVeiculoService>(defaultScopedLifestyle);
            container.Register<IAppTipoVeiculoService, AppTipoVeiculoService>(defaultScopedLifestyle);

            container.Register<IVeiculoRepository, VeiculoRepository>(defaultScopedLifestyle);
            container.Register<IVeiculoService, VeiculoService>(defaultScopedLifestyle);
            container.Register<IAppVeiculoService, AppVeiculoService>(defaultScopedLifestyle);
        }
    }
}
