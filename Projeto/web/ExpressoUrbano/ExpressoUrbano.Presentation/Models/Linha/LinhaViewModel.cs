using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExpressoUrbano.Presentation.Models.Horario;
using ExpressoUrbano.Presentation.Models.Rota;

namespace ExpressoUrbano.Presentation.Models.Linha
{
    public class LinhaViewModel
    {
        public int LinhaId { get; set; }
        public int RotaId { get; set; }
        public string Identificador { get; set; }
        public string Itinerario { get; set; }
        public double Tarifa { get; set; }
        public string Descricao { get; set; }

        public virtual RotaViewModel Rota { get; set; }
        public virtual ICollection<HorarioViewModel> Horarios { get; set; }
    }
}