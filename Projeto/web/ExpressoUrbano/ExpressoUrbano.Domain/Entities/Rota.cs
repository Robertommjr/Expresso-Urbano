using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoUrbano.Domain.Entities
{
    public class Rota
    {
        public int RotaId { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }

        public virtual ICollection<Linha> Linhas { get; set; }
        public virtual ICollection<Ponto> Pontos { get; set; }
    }
}
