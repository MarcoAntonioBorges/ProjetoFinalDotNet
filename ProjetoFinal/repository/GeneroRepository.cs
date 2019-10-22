using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoFinal.Models;
using ProjetoFinal.persistence;

namespace ProjetoFinal.repository
{
    public class GeneroRepository : IGeneroRepository
    {
        private GameStoreContext _context;

        public GeneroRepository(GameStoreContext context)
        {
            _context = context;
        }

        public void Atualizar(Genero genero)
        {
            _context.Generos.Update(genero);
        }

        public Genero BuscarPorCodigo(int codigo)
        {
            return _context.Generos.Find(codigo);
        }

        public void Cadastrar(Genero genero)
        {
            _context.Generos.Add(genero);
        }

        public IList<Genero> Listar()
        {
            return _context.Generos.ToList();
        }

        public void Remover(int codigo)
        {
            _context.Generos.Remove(_context.Generos.Find(codigo));
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}

