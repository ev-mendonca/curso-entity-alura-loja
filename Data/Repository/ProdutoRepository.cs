using Data.Entities;
using Data.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(Context context) : base(context){}

    }
}
