using System;

namespace CarsCollectors.Domain.Entities
{
    public class TipoVeiculo
    {
        private Guid _Id;
        public Guid TipoVeiculoId
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
        public string Observacao { get; set; }
        public string TextoAoExecutarAcaoEspecial { get; set; }
    }
}
