using ExpressoUrbano.Presentation.Models.Linha;
using ExpressoUrbano.Presentation.Models.TipoHorario;

namespace ExpressoUrbano.Presentation.Models.Horario
{
    public class HorarioViewModel
    {
        public int HorarioId { get; set; }
        public int LinhaId { get; set; }
        public int TipoHorarioId { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public string Descricao { get; set; }
        public TipoHorarioViewModel TipoHorario { get; set; }
        public LinhaViewModel Linha { get; set; }
    }
}