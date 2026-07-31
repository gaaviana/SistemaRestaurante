using Microsoft.EntityFrameworkCore;
using SistemaRestaurante.Data;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Services
{
    public class CaixaService
    {
        public void RegistrarPagamento(int comandaId,FormaPagamento formaPagamento,decimal valorRecebido)
        {
            using (var context = new RestauranteContext())
            {
                var comandaBanco = context.Comandas.FirstOrDefault(c => c.Id == comandaId);

                if (comandaBanco == null)
                    return;

                Pagamento pagamento = new Pagamento
                {
                    FormaPagamento = formaPagamento,
                    Valor = comandaBanco.Total,
                    ValorRecebido = valorRecebido,
                    Data = DateTime.Now
                };

                comandaBanco.Pagamento = pagamento;
                comandaBanco.Status = StatusComanda.Finalizada;

                context.SaveChanges();
                //BancoFake.Pagamentos.Add(pagamento);
            }
        }

        private List<Pagamento> ObterPagamentosDoDia(DateTime data)
        {
            using (var context = new RestauranteContext())
            {
                return context.Pagamentos.Where(p => p.Data.Date == data.Date).ToList();
            }
        }

        private List<Comanda> ObterComandasDoDia(DateTime data)
        {
            using(var context = new RestauranteContext())
            {
                return context.Comandas
                    .Include(c => c.Pagamento)
                    .Include(c => c.Itens).ThenInclude(i => i.Produto)
                    .Where(c => c.Status == StatusComanda.Finalizada && c.Pagamento != null && c.Pagamento.Data.Date == data.Date).ToList();
            }
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
