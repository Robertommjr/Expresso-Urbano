using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoUrbano.Domain.Entities
{
    public class Ponto
    {
        public int PontoId { get; set; }
        public int RotaId { get; set; }
        public int Sequencial { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public DateTime DtRegistro { get; set; }
        public DateTime DtModificacao { get; set; }
        public bool Status { get; set; }

        public virtual Rota Rota { get; set; }
    }
}
