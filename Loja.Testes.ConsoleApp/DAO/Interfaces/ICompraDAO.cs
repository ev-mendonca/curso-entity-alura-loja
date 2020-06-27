using Loja.Testes.ConsoleApp.Model;
using System;
using System.Collections.Generic;

namespace Loja.Testes.ConsoleApp.DAO.Interfaces
{
    interface ICompraDAO : IDisposable
    {
        void Inserir(Compra compra);
        void Atualizar(Compra produto);
        void Remover(Compra produto);
        IList<Compra> Listar();
    }
}
