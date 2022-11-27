namespace Cacino.Entidades
{
    public class Rifa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string FechaInicio { get; set; }

        public string FechaFinal { get; set; }
        public List<NumerosdeRifa> NumerosdeRifa { get; set; }
        public List<Participantes> Participantes { get; set; }
    }
}
