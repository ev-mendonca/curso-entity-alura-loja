using Loja.Testes.ConsoleApp;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class ProdutoDAOEntity : BaseDAOEntity, IProdutoDAO
    {
        public ProdutoDAOEntity() : base(){ }

        public void Atualizar(Produto produto)
        {
            Context.Produtos.Update(produto);
            Context.SaveChanges();
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
