using Data.Entities;
using Data.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        public IList<Produto> Listar()
        {
            return Context.Set<Produto>().ToList();
        }
    }
}
