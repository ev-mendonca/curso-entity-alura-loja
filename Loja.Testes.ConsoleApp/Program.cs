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
            
        }
    }
}
