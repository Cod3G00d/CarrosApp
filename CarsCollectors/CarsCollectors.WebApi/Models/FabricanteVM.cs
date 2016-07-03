using System;
using System.ComponentModel.DataAnnotations;

namespace CarsCollectors.WebApi.Models
{
    public class FabricanteVM
    {
        [Key]
        public Guid FabricanteId { get; set; }

        [Required(ErrorMessage ="Campo obrigatório.")]
        public string Nome { get; set; }

        public int AnoFundacao { get; set; }
    }
}