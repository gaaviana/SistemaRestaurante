using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SistemaRestaurante.Data
{
    public class BancoFake
    {
        public static BindingList<Produto> Produtos = new BindingList<Produto>();

        public static BindingList<Produto> Comandas = new BindingList<Produto>();

        public static BindingList<Produto> Pagamentos = new BindingList<Produto>();
    }
}
