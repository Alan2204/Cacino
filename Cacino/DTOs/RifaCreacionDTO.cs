using Cacino.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Cacino.DTOs
{
    public class RifaCreacionDTO
    {
        [Required]
        [Mayuscula]
        public string Nombre { get; set; }

        public string FechaInicio { get; set; }

        public string FechaFinal { get; set; }

        
    }
}
