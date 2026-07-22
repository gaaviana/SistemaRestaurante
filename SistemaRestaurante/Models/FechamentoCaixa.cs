using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{
    public class FechamentoCaixa
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int QuantidadeVendas { get; set; }
        public decimal TotalDinheiro { get; set; }
        public decimal TotalPix { get; set; }
        public decimal TotalDebito { get; set; }
        public decimal TotalCredito { get; set; }
        public decimal TotalGeral { get; set; }


        public FechamentoCaixa(int id, DateTime data, int quantidadeVendas, decimal totalDinheiro, decimal totalPix, decimal totalDebito, decimal totalCredito, decimal totalGeral)
        {
            Id = id;
            Data = data;
            QuantidadeVendas = quantidadeVendas;
            TotalDinheiro = totalDinheiro;
            TotalPix = totalPix;
            TotalDebito = totalDebito;
            TotalCredito = totalCredito;
            TotalGeral = totalGeral;
        }
    }
}
