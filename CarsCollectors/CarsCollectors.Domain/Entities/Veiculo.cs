using System;

namespace CarsCollectors.Domain.Entities
{
    public class Veiculo
    {
        private Guid _Id;
        public Guid VeiculoId
        {
            get
            {
                if (_Id == null || _Id == Guid.Empty)
                {
                    _Id = Guid.NewGuid();
                    return _Id;
                }
                else
                {
                    return _Id;
                }
            }
            set
            {
                _Id = value;
            }
        }
        public string Nome { get; set; }
        public int AnoFabricacao { get; set; }
        public string Modelo { get; set; }
        public Guid FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }
        
    }
}
