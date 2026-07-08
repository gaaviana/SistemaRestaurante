using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Data
{
    public class BancoFake
    {
        public static List<Produto> Produtos = new();

        public static List<Comanda> Comandas = new();

        public static List<Pagamento> Pagamentos = new();
    }
}
