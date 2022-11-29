using Cacino.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Cacino.DTOs
{
    public class PremiosDTO
    {
        public int Id { get; set; }
        public int Lugar { get; set; }
       
        public int Premio { get; set; }
       
        public int IdRifa { get; set; }


        
    }
}
