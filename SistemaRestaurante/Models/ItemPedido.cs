using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

        public int ComandaId { get; set; }

        public Comanda Comanda { get; set; }

        public int Quantidade { get; set; }

        public decimal Subtotal => Produto.Preco * Quantidade;

        public string NomeProduto => Produto?.Nome ?? "";

        public decimal Preco => Produto?.Preco ?? 0;

        public ItemPedido()
        {
        }

        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            ProdutoId = produto.Id;
            Quantidade = quantidade;
        }

        public ItemPedido(ItemPedido outro)
        {
            Produto = outro.Produto;
            ProdutoId = outro.ProdutoId;
            Quantidade = outro.Quantidade;
        }
    }
}
