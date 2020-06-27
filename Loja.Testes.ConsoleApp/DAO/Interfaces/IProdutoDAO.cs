using Loja.Testes.ConsoleApp.Model;
using System;
using System.Collections.Generic;

namespace Loja.Testes.ConsoleApp.DAO.Interfaces
{
    interface IProdutoDAO : IDisposable
    {
        void Inserir(Produto produto);
        void Atualizar(Produto produto);
        void Remover(Produto produto);
        IList<Produto> Listar();
    }
}
