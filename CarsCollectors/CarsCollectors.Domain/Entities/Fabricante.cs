using System;
using System.Collections.Generic;

namespace CarsCollectors.Domain.Entities
{
    public class Fabricante
    {
        private Guid _Id;
        public Guid FabricanteId
        {
            get
            {
                if (_Id == null ||_Id == Guid.Empty)
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
        public int AnoFundacao { get; set; }
        ICollection<Veiculo> Veiculos { get; set; }
        
    }
}