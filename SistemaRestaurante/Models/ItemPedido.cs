using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal { get { return Produto.Preco * Quantidade ?? 0;} }

        public string NomeProduto => Produto.Nome;
        public decimal Preco => Produto.Preco ?? 0;
        public ItemPedido(Produto produto, int qtd)
        {
            
            Produto = produto;
            Quantidade = qtd;
            
        }
        public ItemPedido(ItemPedido outro)
        {
            Produto = outro.Produto;
            Quantidade = outro.Quantidade;
        }
    }
}
