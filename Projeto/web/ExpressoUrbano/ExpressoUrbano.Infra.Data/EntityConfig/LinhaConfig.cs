using ExpressoUrbano.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoUrbano.Infra.Data.EntityConfig
{
    public class LinhaConfig : EntityTypeConfiguration<Linha>
    {
        public LinhaConfig()
        {
            HasKey(l => l.LinhaId);

            Property(l => l.Identificador)
                .IsRequired()
                .HasMaxLength(20);

            Property(l => l.Itinerario)
                .IsRequired()
                .HasMaxLength(100);

            Property(l => l.Tarifa)
                .IsRequired();

            Property(l => l.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            HasRequired(l => l.Rota)
                .WithMany(r => r.Linhas)
                .HasForeignKey(l => l.RotaId);
        }
    }
}
