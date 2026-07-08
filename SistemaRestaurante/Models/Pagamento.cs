using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class Pagamento
    {
        public int Id;
        public string FormaPagamento;
        public decimal Valor;
        public DateTime Data;
    }
}
