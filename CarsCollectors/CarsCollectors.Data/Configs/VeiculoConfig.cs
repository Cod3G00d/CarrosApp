using CarsCollectors.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

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
