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
            Cliente cliente = new Cliente
            {
                Email = "harry.potter@hogwarts.com",
                Nome = "Harry Potter",
                EnderecoDeEntrega = new Endereco
                {
                    CEP = "00.000-00",
                    Logradouro = "Rua dos Alfeneiros",
                    Numero = "4",
                    Complemento = "Embaixo da Escada",
                    Bairro = "Little Whinging",
                    Cidade = "Londres"
                }
            };

            using(var repo = new ClienteDAO())
            {
                repo.Inserir(cliente);
            }
            
            
            
        }
    }
}
