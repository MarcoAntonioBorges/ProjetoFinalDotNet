using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Jogo
    {
        public int JogoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public Plataforma Plataforma { get; set; }

        [DefaultValue(false)]
        public bool Disponivel { get; set; }
        public Genero Genero { get; set; }
        public int GeneroId { get; set; }
    }
}
