using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class Comanda
    {
            public int Id { get; set; }

            public int IdPedido { get; set; }
            public string Tipo { get; set; } 
            public int? Numero { get; set; }
            public string Status { get; set; } 
            public BindingList<ItemPedido> Itens { get; set; } = new BindingList<ItemPedido>();
            public Pagamento Pagamento { get; set; }

            public string FormaPagamento
            {
                get
                {
                    return Pagamento?.FormaPagamento;
                }
            }

            public DateTime? DataPagamento
            {
                get
                {
                    return Pagamento?.Data;
                }
            }
            public decimal Total { get { return Itens.Sum(i => i.Subtotal); } }
        
        public Comanda(int id, int idPedido, string tipo, int? numero, string staus, BindingList<ItemPedido> itens)
        {
            Id = id; 
            IdPedido = idPedido;
            Tipo = tipo; 
            Numero = numero; 
            Status = staus;
            Itens = itens;
        }

        public Comanda(Comanda outra)
        {
            Id = outra.Id;
            IdPedido = outra.IdPedido;
            Tipo = outra.Tipo;
            Numero = outra.Numero;
            Status = outra.Status;

            Itens = new BindingList<ItemPedido>();

            foreach (var item in outra.Itens)
            {
                Itens.Add(new ItemPedido(item));
            }
        }
    }
}
