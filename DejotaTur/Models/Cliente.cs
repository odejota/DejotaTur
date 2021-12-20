using System.ComponentModel.DataAnnotations;

namespace DejotaTur.Models
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        public int AnoNascimento { get; set; }
        [Required]
        [StringLength(11)]
        public string CPF { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(14)]
        public string Telefone { get; set; }
        [StringLength(150)]
        public string Endereço { get; set; }
    }
}