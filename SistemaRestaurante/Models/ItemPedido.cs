using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class ItemPedido
    {
        public Produto Produto;
        public int Quantidade;
        public decimal Subtotal;

        public ItemPedido(Produto produto, int qtd, decimal subtotal)
        {
            Produto = produto;
            Quantidade = qtd;
            Subtotal = subtotal;
        }
    }
}
