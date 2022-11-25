using System.ComponentModel.DataAnnotations;

namespace Cacino.Entidades
{
    public class Participante
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }

        public int Telefono { get; set; }

    }
}
