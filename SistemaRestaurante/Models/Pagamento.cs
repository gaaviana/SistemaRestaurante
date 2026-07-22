using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class Pagamento
    {
        public int Id;
        public FormaPagamento FormaPagamento;
        public decimal Valor;
        public DateTime Data;
    }
}
