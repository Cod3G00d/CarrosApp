using CarsCollectors.Data.Configs;
using CarsCollectors.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CarsCollectors.Data.Context
{
    public class CarsCollectorsContext : DbContext
    {
        public CarsCollectorsContext()
            : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(c => c.IsKey());

            modelBuilder.Properties<string>()
                .Configure(c => c.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(c => c.HasMaxLength(100));


            modelBuilder.Configurations.Add(new VeiculoConfig());
            modelBuilder.Configurations.Add(new FabricanteConfig());
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<TipoVeiculo> TiposVeiculo { get; set; }
    }
}
