using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DigiLibV2.Entidades;
namespace DigiLibV2
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Usuarios> USUARIOS { get; set; }

        public DbSet<Livros> LIVROS { get; set; }
    }
}
