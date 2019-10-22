using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProjetoFinal.repository
{
    public interface IJogoRepository
    {
        void Cadastrar(Jogo jogo);
        void Atualizar(Jogo jogo);
        void Remover(int codigo);
        IList<Jogo> Listar();
        Jogo BuscarPorCodigo(int codigo);
        void Salvar();
        IList<Jogo> BuscarPor(Expression<Func<Jogo, bool>> filtro);

        IList<Jogo> ListarJuntoGenero();
    }
}