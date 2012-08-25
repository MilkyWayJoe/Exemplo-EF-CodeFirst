using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExemploEFCodeFirst
{
    public class Usuario : Pessoa
    {
        [StringLength(500)]
        public string Status { get; set; }
    }
}
