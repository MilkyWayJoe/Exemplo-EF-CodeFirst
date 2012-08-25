using System;
using System.Data.Entity;
using System.Collections.Generic;

namespace ExemploEFCodeFirst
{
    public class ExemploEFCodeFirstDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
