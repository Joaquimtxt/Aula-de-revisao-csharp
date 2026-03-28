using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "O E-mail é Obrigatório")]
        [EmailAddress(ErrorMessage = "O Formato do E-mail deve ser válido")]
        public string? Email { get; set; }

    }
}
