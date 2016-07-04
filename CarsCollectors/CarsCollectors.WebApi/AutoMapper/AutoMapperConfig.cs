using AutoMapper;
using CarsCollectors.Domain.Entities;
using CarsCollectors.WebApi.Models;

namespace CarsCollectors.Mvc.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {   
            Mapper.Initialize(cfg => 
            {
                cfg.CreateMap<Veiculo, VeiculoVM>();
                cfg.CreateMap<VeiculoVM, Veiculo>();
                cfg.CreateMap<Fabricante, FabricanteVM>();
                cfg.CreateMap<FabricanteVM, Fabricante>();
                cfg.CreateMap<TipoVeiculo, TipoVeiculoVM>();
                cfg.CreateMap<TipoVeiculoVM, TipoVeiculo>();
            });
        }
    }
}