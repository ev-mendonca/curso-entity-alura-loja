using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace Loja.Testes.ConsoleApp.DAO
{
    public class ProdutoDAO : BaseDAO, IBaseDAO<Produto>
    {
        public ProdutoDAO() : base() { }

        public void Atualizar(Produto produto)
        {
            Context.Produtos.Update(produto);
            Context.SaveChanges();
        }

        public Produto Carregar(int id)
        {
            return Context.Produtos.Find(id);
        }

        public void Dispose()
        {
            Context.Dispose();
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