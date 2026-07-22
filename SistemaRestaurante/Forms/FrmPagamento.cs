using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.Services;
using SistemaRestaurante.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaRestaurante.Forms
{
    public partial class FrmPagamento : Form
    {
        private readonly ComandaService comandaService;
        private CaixaService caixaService;
        public FrmPagamento(ComandaService service)
        {
            InitializeComponent();

            comandaService = service;
            caixaService = new CaixaService();

            int idPedido = comandaService.ComandaAtual.IdPedido;
            lblNumeroPedido.Text = $"Pedido #{idPedido:D4}";
            lblTipoPedido.Text = comandaService.ComandaAtual.Tipo;
            lblNumeroTipoPedido.Text = comandaService.ComandaAtual.Numero.ToString();
            lblValorTotal.Text = comandaService.ComandaAtual.Total.ToString("C");

            cbPagmento.DataSource = Enum.GetValues(typeof(FormaPagamento));
        }

        private void cbPagmento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTelaPagamento();
        }

        private void txtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            CalcularTroco();
        }

        private void AtualizarTelaPagamento()
        {
            FormaPagamento forma =
                (FormaPagamento)cbPagmento.SelectedItem;

            bool dinheiro = forma == FormaPagamento.Dinheiro;

            lblValorRecebido.Visible = dinheiro;
            txtValorRecebido.Visible = dinheiro;

            lblTroco.Visible = dinheiro;
            lblValorTroco.Visible = dinheiro;
        }
        private void CalcularTroco()
        {
            decimal valorPago;

            if (!decimal.TryParse(txtValorRecebido.Text, out valorPago))
            {
                lblValorTroco.Text = "R$ 0,00";
                return;
            }

            decimal total = comandaService.ComandaAtual.Total;

            decimal troco = valorPago - total;

            if (troco < 0)
                troco = 0;

            lblValorTroco.Text = troco.ToString("C");
        }

        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {

            FormaPagamento forma = (FormaPagamento)cbPagmento.SelectedItem;
            decimal valorRecebido;

            // validação
            if (forma == FormaPagamento.Dinheiro)
            {

                if (!decimal.TryParse(txtValorRecebido.Text, out valorRecebido))
                {
                    MessageBox.Show("Informe o valor recebido.");
                    return;
                }

                if (valorRecebido < comandaService.ComandaAtual.Total)
                {
                    MessageBox.Show("O valor recebido é menor que o total.");
                    return;
                }

                valorRecebido = decimal.Parse(txtValorRecebido.Text);
            }
            else
            {
                valorRecebido = comandaService.ComandaAtual.Total;
            }
            // =========================================================

            caixaService.RegistrarPagamento(comandaService.ComandaOriginal, forma, valorRecebido);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
