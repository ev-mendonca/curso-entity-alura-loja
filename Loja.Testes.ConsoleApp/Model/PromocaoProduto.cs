using System;
using System.Collections.Generic;

namespace Loja.Testes.ConsoleApp.Model
{
    public class PromocaoProduto
    {
        public int PromocaoId { get; internal set; }
        public int ProdutoId { get; internal set; }
        public Promocao Promocao { get; internal set; }
        public Produto Produto { get; internal set; }
    }
}
