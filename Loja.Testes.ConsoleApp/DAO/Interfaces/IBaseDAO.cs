using System;
using System.Collections.Generic;

namespace Loja.Testes.ConsoleApp.DAO.Interfaces
{
    interface IBaseDAO<T> : IDisposable
    {
        void Inserir(T item);
        void Atualizar(T item);
        void Remover(T item);
        IList<T> Listar();
        T Carregar(int id);
    }
}
