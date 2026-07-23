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

        private List<Pagamento> ObterPagamentosDoDia(DateTime data)
        {
            return BancoFake.Pagamentos
                .Where(p => p.Data.Date == data.Date)
                .ToList();
        }

        private List<Comanda> ObterComandasDoDia(DateTime data)
        {
            return BancoFake.Comandas
                .Where(c => c.Status == "Finalizada" &&
                            c.DataPagamento.Value.Date == data.Date)
                .ToList();
        }

        public List<Comanda> ObterVendas(DateTime data)
        {
            return ObterComandasDoDia(data);
        }

        public int QuantidadeVendas(DateTime data)
        {
            return ObterPagamentosDoDia(data).Count;
        }

        public decimal ReceitaTotal(DateTime data)
        {
            return ObterPagamentosDoDia(data).Sum(p => p.Valor);
        }

        public decimal TicketMedio(DateTime data)
        {
            var pagamentos = ObterPagamentosDoDia(data);

            if (pagamentos.Count == 0)
                return 0;

            return pagamentos.Sum(p => p.Valor) / pagamentos.Count;
        }

        public int ItensVendidos(DateTime data)
        {
            return ObterComandasDoDia(data).Sum(c => c.Itens.Sum(i => i.Quantidade));
        }
    }
}
