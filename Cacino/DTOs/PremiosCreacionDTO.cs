using Cacino.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Cacino.DTOs
{
    public class PremiosCreacionDTO
    {
        
        [Required(ErrorMessage = ("Es necesario poner el lugar al que le corresponde el premio."))]
        [Range(1, 54)]
        public int Lugar { get; set; }
        [Required(ErrorMessage = "Es necesario regitrar el premio.")]
        [Range(500, 100000000, ErrorMessage = "El valor del premio no es valido.")]
        public int Premio { get; set; }
       
        
       
    }
}
