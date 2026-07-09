using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal { get { return Produto.Preco * Quantidade;} }

        public string NomeProduto => Produto.Nome;
        public decimal Preco => Produto.Preco;
        public ItemPedido(Produto produto, int qtd)
        {
            
            Produto = produto;
            Quantidade = qtd;
            
        }

       
    }
}
