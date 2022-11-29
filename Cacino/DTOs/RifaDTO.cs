using Cacino.Entidades;
using Cacino.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace Cacino.DTOs
{
    public class RifaDTO
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFinal { get; set; }

        public List<Premios> Premios { get; set; }

    }
}
