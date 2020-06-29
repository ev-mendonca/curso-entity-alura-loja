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
                var dao = new ClienteDAO(context);
                var dao2 = new ProdutoDAO(context);
                var promocoes = dao.CarregarComEnderecos(x=>x.Id == 1);

                var produto = dao2.CarregarComCompras(x=>x.Id == 11);
            }
        }
    }
}
