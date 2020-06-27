using Loja.Testes.ConsoleApp.DAO;
using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;

namespace Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto
            {
                Nome = "Quindin",
                PrecoUnitario = 1.5,
                Categoria = "Confeitaria",
                Unidade = "Unidade"
            };

            Compra compra = new Compra();
            compra.Produto = produto;
            compra.Quantidade = 3;
            compra.Preco = produto.PrecoUnitario * compra.Quantidade;

            using(ICompraDAO repo = new CompraDAO())
            {
                repo.Inserir(compra);
            }
            
        }
    }
}
