namespace Cacino.Entidades
{
    public class Participantes
    {
        public int IdCliente { get; set; }
        public int IdRifa { get; set; }
        public Cliente Cliente { get; set; }
        public Rifa Rifa { get; set; }
    }
}
