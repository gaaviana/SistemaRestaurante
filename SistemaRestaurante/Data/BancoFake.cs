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

        public static BindingList<Comanda> Comandas = new BindingList<Comanda>();

        public static BindingList<Pagamento> Pagamentos = new BindingList<Pagamento>();
    }
}
