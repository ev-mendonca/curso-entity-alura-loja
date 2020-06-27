using Loja.Testes.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class ProdutoDAOEntity : IProdutoDAO
    {
        private LojaContext context;

        public ProdutoDAOEntity()
        {
            context = new LojaContext();
        }

        public void Atualizar(Produto produto)
        {
            context.Produtos.Update(produto);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Inserir(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
        }


        public IList<Produto> Listar()
        {
            return context.Produtos.ToList();
        }

        public void Remover(Produto produto)
        {
            context.Remove(produto);
            context.SaveChanges();
        }
    }
}
