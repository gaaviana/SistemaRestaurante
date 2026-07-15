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
        private Comanda ComandaOriginal;
        public void NovaComanda()
        {
            ComandaOriginal = null;

            int idPedido = BancoFake.Comandas.Count + 1;

            ComandaAtual = new Comanda(
                0,
                idPedido,
                "",
                0,
                "Aberta",
                new BindingList<ItemPedido>()
            );
        }
        public void AbrirComanda(Comanda comanda)
        {
            ComandaOriginal = comanda;

            ComandaAtual = new Comanda(comanda);
        }

        public void AdicionarProduto(Produto produto, int qtd)
        {
            ComandaAtual.Itens.Add(new ItemPedido(produto, qtd));
        }

        public void RemoverProduto(ItemPedido item)
        {
            ComandaAtual.Itens.Remove(item);
        }
        public void SalvarComanda()
        {
            if(ComandaOriginal == null)
            {
                ComandaAtual.Id = BancoFake.Comandas.Count + 1;
                BancoFake.Comandas.Add(ComandaAtual);
            }
            else
            {
                ComandaOriginal.Tipo = ComandaAtual.Tipo;
                ComandaOriginal.Numero = ComandaAtual.Numero;
                ComandaOriginal.Status = ComandaAtual.Status;

                ComandaOriginal.Itens.Clear();

                foreach(var item in ComandaAtual.Itens)
                {
                    ComandaOriginal.Itens.Add(new ItemPedido(item));
                }
            }
        }

        public void Cancelar()
        {
            ComandaAtual = null;
            ComandaOriginal = null;
        }


        public void Finalizar()
        {

        }
    }
}
