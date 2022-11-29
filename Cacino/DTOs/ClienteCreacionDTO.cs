using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cacino.DTOs
{
    public class ClienteCreacionDTO
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        
        public string Contraseña { get; set; }
    }
}
