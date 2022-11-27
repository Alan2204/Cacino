namespace Cacino.Entidades
{
    public class NumerosdeRifa
    {
        public int IdNumero { get; set; }
        public int IdRifa { get; set; }
        public Rifa Rifa { get; set; }
        public Numero Numero { get; set; }
    }
}
