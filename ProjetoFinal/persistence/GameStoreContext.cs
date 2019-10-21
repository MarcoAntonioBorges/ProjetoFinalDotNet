using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.persistence
{
    public class GameStoreContext : DbContext
    {
        public DbSet<Jogo> Jogos { get; set; }

        public DbSet<Genero> Generos { get; set; }

        public GameStoreContext(DbContextOptions o) : base(o) { }
    }
}
