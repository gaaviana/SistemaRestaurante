using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class Comanda
    {
        public int Id;
        public string Tipo;
        public int Numero;
        public string Status;
        public List<ItemPedido> Itens;
        public decimal Total;
    }
}
