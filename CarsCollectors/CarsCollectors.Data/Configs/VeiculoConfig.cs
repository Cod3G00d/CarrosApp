using CarsCollectors.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsCollectors.Data.Configs
{
    class VeiculoConfig : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoConfig()
        {
            HasKey(v => v.VeiculoId);

            Property(v => v.Nome)
                .IsRequired();


            HasRequired(v => v.Fabricante)
                .WithMany()
                .HasForeignKey(f => f.FabricanteId);
        }
    }
}
