using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.repository
{
    interface IGeneroRepository
    {
        void Cadastrar(Genero genero);
        void Atualizar(Genero genero);
        void Remover(int codigo);
        IList<Genero> Listar();
        Genero BuscarPorCodigo(int codigo);
        void Salvar();
    }
}
