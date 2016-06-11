using ExpressoUrbano.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoUrbano.Infra.Data.EntityConfig
{
    public class HorarioConfig : EntityTypeConfiguration<Horario>
    {
        public HorarioConfig()
        {
            HasKey(h => h.HorarioId);

            Property(h => h.Hora)
                .IsRequired();

            Property(h => h.Minuto)
                .IsRequired();

            Property(h => h.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            HasRequired(h => h.TipoHorario)
                .WithMany(th => th.Horarios)
                .HasForeignKey(h => h.TipoHorarioId);

            HasRequired(h => h.Linha)
                .WithMany(l => l.Horarios)
                .HasForeignKey(h => h.LinhaId);
        }
    }
}
