using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExpressoUrbano.Domain.Enums;

namespace ExpressoUrbano.Presentation.Areas.Admin.ViewModels.Linha
{
    public class LinhaViewModel
    {
        public int LinhaId { get; set; }
        public int RotaId { get; set; }
        public string Identificador { get; set; }
        public string Itinerario { get; set; }
        public double Tarifa { get; set; }
        public string Descricao { get; set; }

        public DateTime? DtRegistro { get; set; }
        public DateTime? DtModificacao { get; set; }
        public EnumStatus Status { get; set; }
    }
}