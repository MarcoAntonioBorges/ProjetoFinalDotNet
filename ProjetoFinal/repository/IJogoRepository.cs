using ProjetoFinal.Models;
using System.Collections.Generic;

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
    }
}