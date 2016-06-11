using ExpressoUrbano.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoUrbano.Infra.Data.EntityConfig
{
    public class TipoHorarioConfig : EntityTypeConfiguration<TipoHorario>
    {
        public TipoHorarioConfig() {
            HasKey(th => th.TipoHorarioId);

            Property(th => th.Nome)
                .IsRequired()
                .HasMaxLength(30);

            Property(th => th.Descricao)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
