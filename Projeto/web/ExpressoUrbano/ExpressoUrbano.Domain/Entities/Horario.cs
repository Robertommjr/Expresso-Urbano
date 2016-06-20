using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoUrbano.Domain.Entities
{
    public class Horario
    {
        public int HorarioId { get; set; }
        public int LinhaId { get; set; }
        public int TipoHorarioId { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public string Descricao { get; set; }

        public DateTime? DtRegistro { get; set; }
        public DateTime? DtModificacao { get; set; }
        public bool Status { get; set; }


        public TipoHorario TipoHorario { get; set; }
        public Linha Linha { get; set; }
    }
}
