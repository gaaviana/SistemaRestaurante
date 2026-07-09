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
        ComandaService comandaService = new ComandaService();

        public UcPedido()
        {
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
            CarregarCb();
            CarregarItens();
        }

        private void CarregarCb()
        {
            cbProduto.DataSource = BancoFake.Produtos;
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "Id";
        }
        private void CarregarItens()
        {
            dgvProdutos.DataSource = comandaService.Itens;
        }
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            FrmPagamento frm = new FrmPagamento();
            frm.ShowDialog();
        }

        public event Action PedidoSalvo;
        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            string tipo = rbMesa.Checked ? "Mesa" : "Viagem";
            int numero = int.Parse(cbNumero.Text);
            string status = "Aberta";

            comandaService.CriarComanda(tipo, numero, status);
            comandaService.Itens.Clear();
            PedidoSalvo?.Invoke();
        }


        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)cbProduto.SelectedItem;
            int quantidade = (int)nudQuantidade.Value;

            comandaService.AdicionarProduto(produto, quantidade);

            lblTotal.Text = comandaService.Total.ToString("C");
        }
       
    }
}
