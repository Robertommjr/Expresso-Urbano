using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoUrbano.Domain.Entities
{
    public class Linha
    {
        public int LinhaId { get; set; }
        public int RotaId { get; set; }
        public string Identificador { get; set; }
        public string Itinerario { get; set; }
        public double Tarifa { get; set; }
        public string Descricao { get; set; }

        public DateTime DtRegistro { get; set; }
        public DateTime DtModificacao { get; set; }
        public bool Status { get; set; }

        public virtual Rota Rota { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
