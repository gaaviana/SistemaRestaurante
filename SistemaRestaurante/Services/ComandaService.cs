using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaRestaurante.Services
{
    public class ComandaService
    {
        public BindingList<ItemPedido> Itens = new BindingList<ItemPedido>();
        public decimal Total { get {  return Itens.Sum(i => i.Subtotal); }  }
        public void CriarComanda(string tipo, int numero, string status)
        {
            int id = 1;
            if (BancoFake.Comandas.Count > 0)
            {
                id = BancoFake.Comandas.Max(p => p.Id) + 1;
            }

            Comanda comanda = new Comanda(id, tipo, numero, status, new List<ItemPedido>(Itens));
            BancoFake.Comandas.Add(comanda);
        }

        public void AdicionarProduto(Produto produto, int qtd)
        {
            Itens.Add(new ItemPedido(produto, qtd));
        }

        public void RemoverProduto()
        {

        }

        public void Finalizar()
        {

        }
    }
}
