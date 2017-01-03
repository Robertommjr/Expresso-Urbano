using ExpressoUrbano.Presentation.Models.Rota;

namespace ExpressoUrbano.Presentation.Models.Ponto
{
    public class PontoViewModel
    {
        public int PontoId { get; set; }
        public int RotaId { get; set; }
        public int Sequencial { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public virtual RotaViewModel Rota { get; set; }
    }
}