using System.Collections.Generic;
using ExpressoUrbano.Presentation.Models.Linha;
using ExpressoUrbano.Presentation.Models.Ponto;

namespace ExpressoUrbano.Presentation.Models.Rota
{
    public class RotaViewModel
    {
        public int RotaId { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public virtual ICollection<LinhaViewModel> Linhas { get; set; }
        public virtual ICollection<PontoViewModel> Pontos { get; set; }
    }
}