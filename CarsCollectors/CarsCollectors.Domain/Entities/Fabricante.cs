using System;
using System.Collections.Generic;

namespace CarsCollectors.Domain.Entities
{
    public class Fabricante
    {
        public Guid FabricanteId { get; set; }
        public string Nome { get; set; }
        public int AnoFundacao { get; set; }
        ICollection<Veiculo> Veiculos { get; set; }
    }
}