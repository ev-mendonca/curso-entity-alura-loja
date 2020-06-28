using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Testes.ConsoleApp.DAO
{
    public class ClienteDAO : BaseDAO, IBaseDAO<Cliente>
    {

        public ClienteDAO():base(){}

        public void Atualizar(Cliente cliente)
        {
            Context.Clientes.Update(cliente);
            Context.SaveChanges();
        }

        public Cliente Carregar(int id)
        {
            return Context.Clientes.Find(id);
        }

        public void Dispose()
        {
            Context.Dispose();
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
