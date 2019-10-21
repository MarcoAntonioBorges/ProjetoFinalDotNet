using ProjetoFinal.Models;
using ProjetoFinal.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.repository
{
    public class JogoRepository : IJogoRepository
    {
        private GameStoreContext _context;

        public JogoRepository(GameStoreContext context)
        {
            _context = context;
        }

        public void Atualizar(Jogo jogo)
        {
            _context.Jogos.Update(jogo);
        }

        public Jogo BuscarPorCodigo(int codigo)
        {
            return _context.Jogos.Find(codigo);
        }

        public void Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
        }

        public IList<Jogo> Listar()
        {
            return _context.Jogos.ToList();
        }

        public void Remover(int codigo)
        {
            _context.Jogos.Remove(_context.Jogos.Find(codigo));
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
