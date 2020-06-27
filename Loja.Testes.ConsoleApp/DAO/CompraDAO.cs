using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace Loja.Testes.ConsoleApp.DAO
{
    public class CompraDAO : BaseDAO, ICompraDAO
    {
        public CompraDAO() : base() { }

        public void Atualizar(Compra compra)
        {
            Context.Compras.Update(compra);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Inserir(Compra compra)
        {
            Context.Compras.Add(compra);
            Context.SaveChanges();
        }


        public IList<Compra> Listar()
        {
            return Context.Compras.ToList();
        }

        public void Remover(Compra compra)
        {
            Context.Remove(compra);
            Context.SaveChanges();
        }
    }
}