using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Data;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaRestaurante.Services
{
    public class ComandaService
    {
        private readonly RestauranteContext context;

        public ComandaService()
        {
            context = new RestauranteContext();
        }
        public Comanda ComandaAtual { get; private set; }
        public Comanda ComandaOriginal;

        public void NovaComanda()
        {
            ComandaOriginal = null;

            int NumeroPedido = BancoFake.Comandas.Count + 1;

            ComandaAtual = new Comanda(
                NumeroPedido,
                null,
                null,
                StatusComanda.Aberta,
                new List<ItemPedido>()
            );
        }
        public void AbrirComanda(int id)
        {
            using (var context = new RestauranteContext())
            {
                ComandaOriginal = context.Comandas.Include(c => c.Itens).ThenInclude(i => i.Produto).FirstOrDefault(c => c.Id == id);

                ComandaAtual = new Comanda(ComandaOriginal);
            }
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
            using (var context = new RestauranteContext())
            {
                if (ComandaAtual.Id == 0)
                {
                    foreach (var item in ComandaAtual.Itens)
                    {
                        context.Attach(item.Produto);
                    }

                    context.Comandas.Add(ComandaAtual);
                }
                else
                {
                    Comanda comandaBanco = context.Comandas.Include(c => c.Itens).FirstOrDefault(c => c.Id == ComandaAtual.Id);

                    if (comandaBanco == null)
                        return;

                    comandaBanco.Tipo = ComandaAtual.Tipo;
                    comandaBanco.Numero = ComandaAtual.Numero;
                    comandaBanco.Status = ComandaAtual.Status;

                    context.ItemPedidos.RemoveRange(comandaBanco.Itens);
                    comandaBanco.Itens.Clear();


                    foreach (var item in ComandaAtual.Itens)
                    {
                        context.Attach(item.Produto);

                        comandaBanco.Itens.Add(new ItemPedido
                        {
                            Produto = item.Produto,
                            ProdutoId = item.ProdutoId,
                            Quantidade = item.Quantidade
                        });
                    }
                    // depois vamos tratar os itens
                }

                context.SaveChanges();
            }
        }

        public void Cancelar()
        {
            ComandaAtual = null;
            ComandaOriginal = null;
        }
        public List<Comanda> ComandasAbertas()
        {
            return context.Comandas.Where(x => x.Status == StatusComanda.Aberta).ToList();

            //return BancoFake.Comandas
            //    .Where(x => x.Status == StatusComanda.Aberta)
            //    .ToList();
        }
    }
}
