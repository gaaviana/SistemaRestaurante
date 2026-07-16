using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Services
{
    public class CaixaService
    {
        public void RegistrarPagamento(Comanda comanda, string formaPagamento)
        {
            Pagamento pagameto = new Pagamento
            {
                Id = BancoFake.Pagamentos.Count + 1,
                FormaPagamento = formaPagamento,
                Valor = comanda.Total,
                Data = DateTime.Now
            };

            comanda.Pagamento = pagameto;
            comanda.Status = "Finalizada";

            BancoFake.Pagamentos.Add(pagameto);
        }

        public List<Comanda> ObterVendas()
        {
            return BancoFake.Comandas
                .Where(x => x.Status == "Finalizada")
                .ToList();
        }
    }
}
