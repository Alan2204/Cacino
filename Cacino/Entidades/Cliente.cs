using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cacino.Entidades
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellidos { get; set; } 
        public int Telefono { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public List<Participantes> Participantes { get; set; }

    }
}
