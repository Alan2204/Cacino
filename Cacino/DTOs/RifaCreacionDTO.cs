using Cacino.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Cacino.DTOs
{
    public class RifaCreacionDTO
    {
        [Required]
        [Mayuscula]
        public string Nombre { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFinal { get; set; }
        //public List<int> PremiosId { get; set; }
    }
}
