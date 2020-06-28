using System;
using System.Collections.Generic;

namespace Loja.Testes.ConsoleApp.Model
{
    public class Promocao
    {
        public int Id { get; internal set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataFim { get; internal set; }
        public IList<PromocaoProduto> Produtos { get; internal set; }

        public Promocao()
        {
            this.Produtos = new List<PromocaoProduto>();
        }

        public void AdicionaProdutos(params Produto[] produtos)
        {
            foreach (var produto in produtos)
            {
                this.Produtos.Add(new PromocaoProduto { Produto = produto });
            }
            
        }


    }
}
