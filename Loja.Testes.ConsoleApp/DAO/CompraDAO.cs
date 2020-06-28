using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Loja.Testes.ConsoleApp.DAO
{
    public class CompraDAO : BaseDAO, IBaseDAO<Compra>
    {
        public CompraDAO() : base() { }

        public void Atualizar(Compra compra)
        {
            Context.Compras.Update(compra);
            Context.SaveChanges();
        }

        public Compra Carregar(int id)
        {
            return Context.Compras.Find(id);
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