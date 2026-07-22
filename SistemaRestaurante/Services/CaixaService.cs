using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Services
{
    public class CaixaService
    {
        public void RegistrarPagamento(Comanda comanda,FormaPagamento formaPagamento,decimal valorRecebido)
        {
            Pagamento pagamento = new Pagamento
            {
                Id = BancoFake.Pagamentos.Count + 1,
                FormaPagamento = formaPagamento,
                Valor = comanda.Total,
                ValorRecebido = valorRecebido,
                Data = DateTime.Now
            };

            comanda.Pagamento = pagamento;
            comanda.Status = "Finalizada";

            BancoFake.Pagamentos.Add(pagamento);
        }

        public List<Comanda> ObterVendas()
        {
            return BancoFake.Comandas
                .Where(x => x.Status == "Finalizada")
                .ToList();
        }

        public int QuantidadeVendas()
        {
            return BancoFake.Pagamentos.Count;
        }

        public decimal ReceitaTotal()
        {
            return BancoFake.Pagamentos.Sum(p => p.Valor);
        }

        public decimal TicketMedio()
        {
            return BancoFake.Pagamentos.Sum(p => p.Valor) / BancoFake.Pagamentos.Count;
        }

        public int ItensVendidos()
        {
            return BancoFake.Comandas.Where(c => c.Status == "Finalizada").Sum(c => c.Itens.Sum(i => i.Quantidade));
        }
    }
}
