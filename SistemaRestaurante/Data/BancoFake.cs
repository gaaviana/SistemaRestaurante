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
        }

    }
}
