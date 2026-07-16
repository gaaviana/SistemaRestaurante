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
        }
        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnConfirmarPagamento_Click(object sender, EventArgs e)
        {

            string formaPagamento = cbPagmento.Text;

            caixaService.RegistrarPagamento(comandaService.ComandaOriginal, formaPagamento);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
