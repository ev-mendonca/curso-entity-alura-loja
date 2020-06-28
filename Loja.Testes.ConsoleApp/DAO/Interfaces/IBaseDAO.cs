using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Loja.Testes.ConsoleApp.DAO.Interfaces
{
    interface IBaseDAO<T> : IDisposable
    {
        void Inserir(T item);
        void Atualizar(T item);
        void Remover(T item);
        IList<T> Listar();
        IList<T> Filtrar(Expression<Func<T, bool>> filter);
        T Carregar(int id);
        T Carregar(Expression<Func<T, bool>> filter);
    }
}
