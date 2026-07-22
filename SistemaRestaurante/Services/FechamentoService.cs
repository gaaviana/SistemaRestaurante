using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Services
{
    public class FechamentoService
    {
        public void GerarFechamento(DateTime data)
        {
            var pagamentosHoje = BancoFake.Pagamentos.Where(p => p.Data.Date == data.Date).ToList();

            int id = BancoFake.fechamentos.Count + 1;

            int totalVendas = pagamentosHoje.Count;
            decimal totalDinheiro = pagamentosHoje.Where(p => p.FormaPagamento == FormaPagamento.Dinheiro).Sum(p => p.Valor);
            decimal totalPix = pagamentosHoje.Where(p => p.FormaPagamento == FormaPagamento.Pix).Sum(p => p.Valor);
            decimal totalDebito = pagamentosHoje.Where(p => p.FormaPagamento == FormaPagamento.CartaoDebito).Sum(p => p.Valor);
            decimal totalCredito = pagamentosHoje.Where(p => p.FormaPagamento == FormaPagamento.CartaoCredito).Sum(p => p.Valor);
            decimal totalGeral = pagamentosHoje.Sum(p => p.Valor);


            FechamentoCaixa fechamentoHoje = new FechamentoCaixa(id, data, totalVendas, totalDinheiro, totalPix, totalDebito, totalCredito, totalGeral);
            // BancoFake.fechamentos.Add(fechamentoHoje);
            MessageBox.Show($"{fechamentoHoje.Id}\n" +
                            $"{fechamentoHoje.Data}\n" +
                            $"{fechamentoHoje.QuantidadeVendas}\n" +
                            $"{fechamentoHoje.TotalDinheiro}\n" +
                            $"{fechamentoHoje.TotalPix}\n" +
                            $"{fechamentoHoje.TotalDebito}\n" + 
                            $"{fechamentoHoje.TotalCredito}\n" + 
                            $"{fechamentoHoje.TotalGeral}\n" 
                            );
        }
    }
}
