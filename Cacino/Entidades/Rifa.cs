using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Cacino.Validaciones;

namespace Cacino.Entidades
{
    public class Rifa 
    {
        
        public int Id { get; set; }
        [Mayuscula]
        [Required]
        [MaxLength(100, ErrorMessage ="El nombre de la rifa es demasiado largo, favor de registrar un nombre mas corto")]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFinal { get; set; }
        
        public List<Participantes> Participantes { get; set; }
        public List<Premios> Premios { get; set; }
    }
}
