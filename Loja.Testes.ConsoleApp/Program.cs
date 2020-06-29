using Loja.Testes.ConsoleApp.DAO;
using Loja.Testes.ConsoleApp.DAO.Contexts;
using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using Microsoft.EntityFrameworkCore;
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
            Produto produtoSemCompras, produtoComComprasAcimaDe50, produtoComTodasCompras; 
            using(LojaContext context = new LojaContext())
            {
                var dao = new ProdutoDAO(context);
                produtoSemCompras = dao.Carregar(12);
                
            }
            using(LojaContext context = new LojaContext())
            {
                var dao = new ProdutoDAO(context);
                produtoComComprasAcimaDe50 = dao.CarregarComCompras(x => x.Id == 12, x => x.Preco > 50);
            }

            using (LojaContext context = new LojaContext())
            {
                var dao = new ProdutoDAO(context);
                produtoComTodasCompras = dao.CarregarComCompras(x => x.Id == 12);
            }
        }
    }
}
