using System;
using System.Collections.Generic;

namespace ExpressoUrbano.Presentation.Models.TipoHorario
{
    public class TipoHorarioViewModel
    {
        public int TipoHorarioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtRegistro { get; set; }
        public DateTime DtModificacao { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<TipoHorarioViewModel> Horarios { get; set; }
    }
}