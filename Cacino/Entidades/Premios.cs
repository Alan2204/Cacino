using System.ComponentModel.DataAnnotations;

namespace Cacino.Entidades
{
    public class Premios
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage =("Es necesario poner el lugar al que le corresponde el premio."))]
        [Range(1,54)]
        public int Lugar { get; set; }
        [Required(ErrorMessage ="Es necesario regitrar el premio.")]
        [Range(500,100000000, ErrorMessage ="El valor del premio no es valido.")]
        public int Premio { get; set; }
        [Required(ErrorMessage =("Es neceario el id de la rifa."))]
        public int RifaId { get; set; }
        public Rifa Rifa { get; set; }

    }
}
