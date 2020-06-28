using Loja.Testes.ConsoleApp.DAO.Contexts;
using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Testes.ConsoleApp.DAO
{
    public class ClienteDAO : BaseDAO, IBaseDAO<Cliente>
    {
        

        public ClienteDAO(LojaContext context):base(context){}

        public void Atualizar(Cliente cliente)
        {
            Context.Clientes.Update(cliente);
            Context.SaveChanges();
        }

        public Cliente Carregar(int id)
        {
            return Context.Clientes.Find(id);
        }

        public Cliente Carregar(Expression<Func<Cliente, bool>> filter)
        {
            return Context.Clientes.Where(filter).FirstOrDefault();
        }


        public IList<Cliente> Filtrar(Expression<Func<Cliente, bool>> filter)
        {
            return Context.Clientes.Where(filter).ToList();
        }

        public void Inserir(Cliente cliente)
        {
            Context.Clientes.Add(cliente);
            Context.SaveChanges();
        }

        public IList<Cliente> Listar()
        {
            return Context.Clientes.ToList();
        }

        public void Remover(Cliente cliente)
        {
            Context.Clientes.Remove(cliente);
            Context.SaveChanges();
        }
    }
}
