using System;
using System.Collections.Generic;
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
            public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
            public decimal Total { get { return Itens.Sum(i => i.Subtotal); } }
        
        public Comanda(int id, int idPedido, string tipo, int? numero, string staus, List<ItemPedido> itens)
        {
            Id = id; 
            IdPedido = idPedido;
            Tipo = tipo; 
            Numero = numero; 
            Status = staus;
            Itens = itens;
        }
    }
}
