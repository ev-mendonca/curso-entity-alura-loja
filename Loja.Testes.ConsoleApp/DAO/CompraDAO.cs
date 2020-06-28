using Loja.Testes.ConsoleApp.DAO.Contexts;
using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Loja.Testes.ConsoleApp.DAO
{
    public class CompraDAO : BaseDAO, IBaseDAO<Compra>
    {
        public CompraDAO(LojaContext context) : base(context) { }

        public void Atualizar(Compra compra)
        {
            Context.Compras.Update(compra);
            Context.SaveChanges();
        }

        public Compra Carregar(int id)
        {
            return Context.Compras.Find(id);
        }

        public Compra Carregar(Expression<Func<Compra, bool>> filter)
        {
            return Context.Compras.Where(filter).FirstOrDefault();
        }


        public IList<Compra> Filtrar(Expression<Func<Compra, bool>> filter)
        {
            return Context.Compras.Where(filter).ToList();
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