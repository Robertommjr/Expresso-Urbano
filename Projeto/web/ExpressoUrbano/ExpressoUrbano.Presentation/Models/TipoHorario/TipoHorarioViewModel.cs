using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressoUrbano.Presentation.Models.TipoHorario
{
    public class TipoHorarioViewModel
    {
        public int TipoHorarioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TipoHorarioViewModel> Horarios { get; set; }
    }
}