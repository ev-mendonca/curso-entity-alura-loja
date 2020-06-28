using Loja.Testes.ConsoleApp.DAO.Interfaces;
using Loja.Testes.ConsoleApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace Loja.Testes.ConsoleApp.DAO
{
    public class PromocaoDAO : BaseDAO, IBaseDAO<Promocao>
    {
        public PromocaoDAO() : base() { }

        public void Atualizar(Promocao promocao)
        {
            Context.Promocoes.Update(promocao);
            Context.SaveChanges();
        }

        public Promocao Carregar(int id)
        {
            return Context.Promocoes.Find(id);
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Inserir(Promocao promocao)
        {
            Context.Promocoes.Add(promocao);
            Context.SaveChanges();
        }


        public IList<Promocao> Listar()
        {
            return Context.Promocoes.ToList();
        }

        public void Remover(Promocao promocao)
        {
            Context.Remove(promocao);
            Context.SaveChanges();
        }
    }
}