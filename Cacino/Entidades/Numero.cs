namespace Cacino.Entidades
{
    public class Numero
    {
        public int Id { get; set; }

        public int Ficha { get; set; }
        public List<NumerosdeRifa> NumerosdeRifa { get; set; }
    }
}
