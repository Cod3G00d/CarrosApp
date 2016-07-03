using System;

namespace CarsCollectors.Domain.Entities
{
    public class Veiculo
    {
        public Guid VeiculoId { get; set; }
        public string Nome { get; set; }
        public int AnoFabricacao { get; set; }
        public string Modelo { get; set; }
        public Guid FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}
