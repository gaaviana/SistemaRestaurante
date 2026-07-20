using SistemaRestaurante.Models;
using SistemaRestaurante.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaRestaurante.Data
{
    public class BancoFake
    {
        public static BindingList<Produto> Produtos = new BindingList<Produto>();

        public static BindingList<Comanda> Comandas = new BindingList<Comanda>();

        public static BindingList<Pagamento> Pagamentos = new BindingList<Pagamento>();

         static BancoFake()
        {
            Produtos.Add(new Produto("X-burguer", "Lancher", 25.90m));
            Produtos.Add(new Produto("X-Salada", "Lancher", 27.90m));
            Produtos.Add(new Produto("Batata Frita", "Porções", 18.50m));
            Produtos.Add(new Produto("Coca-Cola 2l", "Bebidas", 12.00m));
            Produtos.Add(new Produto("Pizza Calabresa", "Pizza", 54.90m));

            Comanda c1 = new Comanda(1, 1, "Mesa", 10, "Aberta", new BindingList<ItemPedido> { new ItemPedido(Produtos[0], 1), new ItemPedido(Produtos[1], 1)});
            Comanda c2 = new Comanda(2, 2, "Viagem", 401, "Finalizada", new BindingList<ItemPedido> { new ItemPedido(Produtos[2], 2), new ItemPedido(Produtos[3], 1)});
            Comanda c3 = new Comanda(3, 3, "Mesa", 9, "Finalizada", new BindingList<ItemPedido> { new ItemPedido(Produtos[0], 3), new ItemPedido(Produtos[3], 1)});
            Comanda c4 = new Comanda(4, 4, "Viagem", 402, "Aberta", new BindingList<ItemPedido> { new ItemPedido(Produtos[4], 1), new ItemPedido(Produtos[3], 1)});
            Comanda c5 = new Comanda(5, 5, "Mesa", 11, "Finalizada", new BindingList<ItemPedido> { new ItemPedido(Produtos[4], 2), new ItemPedido(Produtos[2], 1)});
            Comanda c6 = new Comanda(6, 6, "Viagem", 403, "Aberta", new BindingList<ItemPedido> { new ItemPedido(Produtos[0], 3), new ItemPedido(Produtos[3], 1)});
            Comandas.Add(c1); Comandas.Add(c2); Comandas.Add(c3); Comandas.Add(c4); Comandas.Add(c5); Comandas.Add(c6);

            c2.Pagamento = new Pagamento {Id = 1, FormaPagamento = "Pix", Valor = c2.Total, Data = DateTime.Now};
            c3.Pagamento = new Pagamento{ Id = 2, FormaPagamento = "Cartão", Valor = c3.Total, Data = DateTime.Now.AddMinutes(-20)};
            c5.Pagamento = new Pagamento{ Id = 3, FormaPagamento = "Dinheiro", Valor = c5.Total, Data = DateTime.Now.AddHours(-1)};

            Pagamentos.Add(c2.Pagamento);
            Pagamentos.Add(c3.Pagamento);
            Pagamentos.Add(c5.Pagamento);
        }

    }
}
