using ExpressoUrbano.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoUrbano.Infra.Data.EntityConfig
{
    public class PontoConfig : EntityTypeConfiguration<Ponto>
    {
        public PontoConfig()
        {
            HasKey(p => p.PontoId);

            Property(p => p.Sequencial)
                .IsRequired();

            Property(p => p.Latitude)
                .IsRequired();

            Property(p => p.Longitude)
                .IsRequired();

            HasRequired(p => p.Rota)
               .WithMany(r => r.Pontos)
               .HasForeignKey(p => p.RotaId);
        }
    }
}
