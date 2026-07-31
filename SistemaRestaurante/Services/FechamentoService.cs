using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.Utils;
using SistemaRestaurante.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Services
{
    public class FechamentoService
    {
        public List<FechamentoCaixa> ListarFechamento()
        {
            using (var context = new RestauranteContext())
            {
                return context.FechamentoCaixas.OrderByDescending(f => f.Data).ToList();
            }
        }
        public void GerarFechamento(DateTime data)
        {
           using (var context = new RestauranteContext())
            {
            var pagamentosHoje = context.Pagamentos.Where(p => p.Data.Date == data.Date).ToList();

            int totalVendas = pagamentosHoje.Count;
            decimal totalDinheiro = pagamentosHoje.Where(p => p.FormaPagamento == FormaPagamento.Dinheiro).Sum(p => p.Valor);
            decimal totalPix = pagamentosHoje.Where(p => p.FormaPagamento == FormaPagamento.Pix).Sum(p => p.Valor);
            decimal totalDebito = pagamentosHoje.Where(p => p.FormaPagamento == FormaPagamento.CartaoDebito).Sum(p => p.Valor);
            decimal totalCredito = pagamentosHoje.Where(p => p.FormaPagamento == FormaPagamento.CartaoCredito).Sum(p => p.Valor);
            decimal totalGeral = pagamentosHoje.Sum(p => p.Valor);


            FechamentoCaixa fechamentoHoje = new FechamentoCaixa(data, totalVendas, totalDinheiro, totalPix, totalDebito, totalCredito, totalGeral);

            if (!FechamentoValidation.Validar(fechamentoHoje))
            {
                return;
            }
            
            context.FechamentoCaixas.Add(fechamentoHoje);
                context.SaveChanges();

            }
        }
    }
}
