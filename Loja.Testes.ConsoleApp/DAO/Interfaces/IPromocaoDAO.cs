using Loja.Testes.ConsoleApp.Model;
using System;
using System.Collections.Generic;

namespace Loja.Testes.ConsoleApp.DAO.Interfaces
{
    interface IPromocaoDAO : IDisposable
    {
        void Inserir(Promocao compra);
        void Atualizar(Promocao produto);
        void Remover(Promocao produto);
        IList<Promocao> Listar();
    }
}
