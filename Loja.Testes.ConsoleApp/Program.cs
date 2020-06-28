using Loja.Testes.ConsoleApp.DAO;
using Loja.Testes.ConsoleApp.DAO.Contexts;
using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using(var repo = new ProdutoDAO())
            {
                var produtos = repo.Filtrar(x => x.Categoria == "Livros");
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
                
            }
            
        }
    }
}
