using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DigiLib_V2.Entidades;
namespace DigiLib_V2
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Usuarios> USUARIOS { get; set; }

        public DbSet<Livros> LIVROS { get; set; }
    }
}
