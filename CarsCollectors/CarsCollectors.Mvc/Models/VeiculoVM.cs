using System;
using System.ComponentModel.DataAnnotations;

namespace CarsCollectors.Mvc.Models
{
    public class VeiculoVM
    {
        [Key]
        public Guid VeiculoId { get; set; }

        [Required(ErrorMessage ="Campo obrigatório", AllowEmptyStrings =false)]
        public string Nome { get; set; }

        [Range(1500, 3000, ErrorMessage = "Valor inválido.")]
        public int AnoFabricacao { get; set; }
        public string Modelo { get; set; }
        public Guid FabricanteId { get; set; }
        public FabricanteVM Fabricante { get; set; }
    }
}