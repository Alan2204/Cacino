using System.ComponentModel;

namespace Cacino.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; } 
        public int Telefono { get; set; }
        public string Email { get; set; }
        public List<Participantes> Participantes { get; set; }

    }
}
