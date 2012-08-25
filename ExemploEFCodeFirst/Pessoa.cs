using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploEFCodeFirst
{
    public abstract class Pessoa
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string PrimeiroNome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string UltimoNome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Email { get; set; }
    }
}
