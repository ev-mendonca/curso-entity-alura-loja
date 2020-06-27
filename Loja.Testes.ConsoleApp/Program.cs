using Alura.Loja.Testes.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //InserirProduto();
            ListarProdutos();
            //RemoverProdutos();
            //AtualizarPrimeiroProduto();

            Console.ReadLine();
        }

        private static void AtualizarPrimeiroProduto()
        {
            using (IProdutoDAO repo = new ProdutoDAO())
            {
                ListarProdutos();
                Produto primeiroProduto = repo.Listar().FirstOrDefault();
                primeiroProduto.Nome = "Tropa de Elite";
                repo.Atualizar(primeiroProduto);
                ListarProdutos();
            }
        }

        private static void RemoverProdutos()
        {
            using(IProdutoDAO repo = new ProdutoDAO())
            {
                IList<Produto> produtos = repo.Listar();
                foreach (var item in produtos)
                {
                    repo.Remover(item);
                }
            }
        }

        private static void ListarProdutos()
        {
            using(IProdutoDAO repo = new ProdutoDAO())
            {
                IList<Produto> produtos = repo.Listar();
                Console.WriteLine($"Foram encontrados {produtos.Count} produtos");
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void InserirProduto()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;
            
            using (IProdutoDAO repo = new ProdutoDAO())
            {
                repo.Inserir(p);
            }
        }

        
    }
}
