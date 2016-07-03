using System;

namespace CarsCollectors.Domain.Entities
{
    public class TipoVeiculo
    {
        public Guid TipoVeiculoId { get; set; }
        public string Observacao { get; set; }
        public string TextoAoExecutarAcaoEspecial { get; set; }
    }
}
