using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExemploEFCodeFirst
{
    public class Post
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public virtual Post ParentPost { get; set; }

        [Required]
        public virtual Usuario Autor { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Titulo { get; set; }

        [StringLength(2000, MinimumLength = 10)]
        public string Conteudo { get; set; }

    }
}
