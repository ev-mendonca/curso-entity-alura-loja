using Loja.Testes.ConsoleApp.DAO;
using Loja.Testes.ConsoleApp.DAO.Contexts;
using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(LojaContext context = new LojaContext())
            {
                var produtoDAO = new ProdutoDAO(context);
                var promocaoDAO = new PromocaoDAO(context);

                var produtos = produtoDAO.Filtrar(x => x.Categoria == "Livros");

                var promocoes = promocaoDAO.Listar();
            }
        }
    }
}
