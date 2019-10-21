using System.Collections.Generic;

namespace ProjetoFinal.Models
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Nome { get; set; }

        public IList<Jogo> Jogos { get; set; }
    }
}