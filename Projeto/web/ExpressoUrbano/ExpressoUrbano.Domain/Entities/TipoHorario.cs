using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoUrbano.Domain.Entities
{
    public class TipoHorario
    {
        public int TipoHorarioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public DateTime? DtRegistro { get; set; }
        public DateTime? DtModificacao { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
