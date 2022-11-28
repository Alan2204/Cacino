using System.ComponentModel.DataAnnotations;

namespace Cacino.DTOs
{
    public class EditarAdminDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
