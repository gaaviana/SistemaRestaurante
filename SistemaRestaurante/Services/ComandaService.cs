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
        public Comanda ComandaAtual { get; private set; }
        public void NovaComanda()
        {
            int idPedido = BancoFake.Comandas.Count + 1;

            ComandaAtual = new Comanda(
                0,
                idPedido,
                "",
                0,
                "Aberta",
                new List<ItemPedido>()
            );
        }
        public void AbrirComanda(Comanda comanda)
        {
            ComandaAtual = comanda;
        }

        public void AdicionarProduto(Produto produto, int qtd)
        {
            ComandaAtual.Itens.Add(new ItemPedido(produto, qtd));
        }

        public void SalvarComanda()
        {
            if (ComandaAtual.Id == 0)
            {
                ComandaAtual.Id = BancoFake.Comandas.Count + 1;
                BancoFake.Comandas.Add(ComandaAtual);
            }
        }

        public void RemoverProduto(ItemPedido item)
        {
            ComandaAtual.Itens.Remove(item);
        }

        public void Finalizar()
        {

        }
    }
}
