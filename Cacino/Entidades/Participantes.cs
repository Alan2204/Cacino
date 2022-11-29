using System.ComponentModel.DataAnnotations;

namespace Cacino.Entidades
{
    public class Participantes
    {
        public int IdRifa { get; set; }
        
        public int IdCliente { get; set; }
        [Required]
        [Range(1,54)]
        public int Ficha { get; set; }
        public Cliente Cliente { get; set; }
        public Rifa Rifa { get; set; }
    }
}
