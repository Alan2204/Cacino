namespace Cacino.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public List<RifaDTO> Rifa { get; set; }
    }
}
