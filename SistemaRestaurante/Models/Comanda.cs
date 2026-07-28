using SistemaRestaurante.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class Comanda
    {
        public int Id { get; set; } // Chave primária do banco

        public int NumeroPedido { get; set; } // Número exibido ao usuário

        public TipoComanda Tipo { get; set; }

        public int? Numero { get; set; }

        public StatusComanda Status { get; set; }

        public List<ItemPedido> Itens { get; set; } = new();

        public Pagamento Pagamento { get; set; }

        public FormaPagamento? FormaPagamento => Pagamento?.FormaPagamento;

        public DateTime? DataPagamento => Pagamento?.Data;

        public decimal Total => Itens.Sum(i => i.Subtotal);

        public Comanda()
        {
        }

        public Comanda(int numeroPedido, TipoComanda tipo, int? numero, StatusComanda status, List<ItemPedido> itens)
        {
            NumeroPedido = numeroPedido;
            Tipo = tipo;
            Numero = numero;
            Status = status;
            Itens = itens;
        }

        public Comanda(Comanda outra)
        {
            Id = outra.Id;
            NumeroPedido = outra.NumeroPedido;
            Tipo = outra.Tipo;
            Numero = outra.Numero;
            Status = outra.Status;

            Itens = new List<ItemPedido>();

            foreach (var item in outra.Itens)
            {
                Itens.Add(new ItemPedido(item));
            }
        }
    }
}
