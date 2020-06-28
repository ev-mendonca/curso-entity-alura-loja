using Loja.Testes.ConsoleApp.DAO;
using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using System;

namespace Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto
            {
                Nome = "Chocolate em Barra",
                PrecoUnitario = 4.5,
                Categoria = "Bomboniere",
                Unidade = "Unidade"
            };

            Produto p2 = new Produto
            {
                Nome = "Ovo de Pascoa",
                PrecoUnitario = 35.00,
                Categoria = "Bomboniere",
                Unidade = "Unidade"
            };

            Promocao promocao = new Promocao
            {
                Descricao = "Doce Pascoa",
                DataInicio = DateTime.Now,
                DataFim = DateTime.Now.AddMonths(2)
            };

            promocao.AdicionaProduto(p1, p2);

            using(var repo = new PromocaoDAO())
            {
                repo.Inserir(promocao);
            }
            
            
        }
    }
}
