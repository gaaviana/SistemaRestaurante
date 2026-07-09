using SistemaRestaurante.Data;
using SistemaRestaurante.Forms;
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
    public partial class UcPedido : UserControl
    {
        private readonly ComandaService comandaService;

        public UcPedido(ComandaService service)
        {
            InitializeComponent();

            comandaService = service;

            dgvProdutos.AutoGenerateColumns = false;

            CarregarCb();

            if (comandaService.ComandaAtual != null)
            {
                CarregarItens();

                lblTotal.Text = comandaService.ComandaAtual.Total.ToString("C");
            }

            AtualizarTela();
        }

        private void AtualizarTela()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = comandaService.ComandaAtual.Itens;

            lblTotal.Text = comandaService.ComandaAtual.Total.ToString("C");

            cbNumero.Text = comandaService.ComandaAtual.Numero == 0
                ? ""
                : comandaService.ComandaAtual.Numero.ToString();

            rbMesa.Checked = comandaService.ComandaAtual.Tipo == "Mesa";
            rbViagem.Checked = comandaService.ComandaAtual.Tipo == "Viagem";
        }

        private void CarregarCb()
        {
            cbProduto.DataSource = BancoFake.Produtos;
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "Id";
        }
        private void CarregarItens()
        {
            dgvProdutos.DataSource = comandaService.ComandaAtual;
        }
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            FrmPagamento frm = new FrmPagamento();
            frm.ShowDialog();
        }

        public event Action PedidoSalvo;
        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            comandaService.ComandaAtual.Tipo =
                rbMesa.Checked ? "Mesa" : "Viagem";

            comandaService.ComandaAtual.Numero =
                int.Parse(cbNumero.Text);

            comandaService.ComandaAtual.Status = "Aberta";

            comandaService.SalvarComanda();

            PedidoSalvo?.Invoke();
        }


        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)cbProduto.SelectedItem;
            int quantidade = (int)nudQuantidade.Value;

            comandaService.AdicionarProduto(produto, quantidade);

            AtualizarTela();
        }
       
    }
}
