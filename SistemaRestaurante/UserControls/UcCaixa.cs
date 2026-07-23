using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaRestaurante.UserControls
{
    public partial class UcCaixa : UserControl
    {
        private CaixaService caixaService = new CaixaService();
        private FechamentoService fechamentoService = new FechamentoService();
        private DateTime dataSelecionada;
        public UcCaixa()
        {
            InitializeComponent();

            dgvCaixa.AutoGenerateColumns = false;
            dataSelecionada = dtpData.Value.Date;
            AtualizarTela();
        }

        public void AtualizarTela()
        {
            if (BancoFake.Pagamentos.Count > 0)
            {
                lblVendasValor.Text = caixaService.QuantidadeVendas(dataSelecionada).ToString();
                lblReceitaValor.Text = caixaService.ReceitaTotal(dataSelecionada).ToString("C");
                lblTicketValor.Text = caixaService.TicketMedio(dataSelecionada).ToString("C");
                lblItensValor.Text = caixaService.ItensVendidos(dataSelecionada).ToString();
            }


            dgvCaixa.DataSource = null;
            dgvCaixa.DataSource = caixaService.ObterVendas(dataSelecionada);
        }

        private void btnFechamento_Click(object sender, EventArgs e)
        {
            fechamentoService.GerarFechamento(dataSelecionada);
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            dataSelecionada = dtpData.Value.Date;
            AtualizarTela();
        }
    }
}
