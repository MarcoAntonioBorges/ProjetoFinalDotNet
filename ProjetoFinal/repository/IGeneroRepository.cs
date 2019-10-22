using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjetoFinal.repository
{
    public interface IGeneroRepository
    {
        void Cadastrar(Genero genero);
        void Atualizar(Genero genero);
        void Remover(int codigo);
        IList<Genero> Listar();

        IList<Genero> BuscarPor(Expression<Func<Genero, bool>> filtro);
        Genero BuscarPorCodigo(int codigo);
        void Salvar();
    }
}
