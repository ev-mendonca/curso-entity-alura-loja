using System;
using System.Collections.Generic;

namespace Loja.Testes.ConsoleApp.DAO.Interfaces
{
    interface IBaseDAO<T> : IDisposable
    {
        void Inserir(T compra);
        void Atualizar(T produto);
        void Remover(T produto);
        IList<T> Listar();
        T Carregar(int id);
    }
}
