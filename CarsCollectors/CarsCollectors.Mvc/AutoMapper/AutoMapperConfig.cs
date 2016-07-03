using AutoMapper;
using CarsCollectors.Domain.Entities;
using CarsCollectors.Mvc.Models;

namespace CarsCollectors.Mvc.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => 
            {
                cfg.CreateMap<Veiculo, VeiculoVM>();
                cfg.CreateMap<Fabricante, FabricanteVM>();
                cfg.CreateMap<TipoVeiculo, TipoVeiculoVM>();
            });
        }
    }
}