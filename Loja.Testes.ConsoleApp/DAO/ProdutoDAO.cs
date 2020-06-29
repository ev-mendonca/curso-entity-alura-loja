using Loja.Testes.ConsoleApp.DAO.Contexts;
using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Loja.Testes.ConsoleApp.DAO
{
    public class ProdutoDAO : BaseDAO, IBaseDAO<Produto>
    {
        public ProdutoDAO(LojaContext context) : base(context) { }

        public void Atualizar(Produto produto)
        {
            Context.Produtos.Update(produto);
            Context.SaveChanges();
        }

        public Produto Carregar(int id)
        {
            return Context.Produtos.Find(id);
        }

        public Produto Carregar(Expression<Func<Produto, bool>> filter)
        {
            return Context.Produtos.Where(filter).FirstOrDefault();
        }

        public Produto CarregarComCompras(Expression<Func<Produto, bool>> filter, Expression<Func<Compra, bool>> filterCompra = null)
        {
            if(filterCompra == null)
                return Context.Produtos.Include(x=>x.Compras).Where(filter).FirstOrDefault();
            else
            {
                Produto produto = Carregar(filter);
                Context.Entry(produto)
                    .Collection(x => x.Compras)
                    .Query()
                    .Where(filterCompra)
                    .Load();    
                return produto;
            }
                
        }



        public IList<Produto> Filtrar(Expression<Func<Produto, bool>> filter)
        {
            return Context.Produtos.Where(filter).ToList();
        }

        public void Inserir(Produto produto)
        {
            Context.Produtos.Add(produto);
            Context.SaveChanges();
        }


        public IList<Produto> Listar()
        {
            return Context.Produtos.ToList();
        }

        public void Remover(Produto produto)
        {
            Context.Remove(produto);
            Context.SaveChanges();
        }
    }
}