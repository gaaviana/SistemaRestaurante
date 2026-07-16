using SistemaRestaurante.Data;
using SistemaRestaurante.Forms;
using SistemaRestaurante.Models;
using SistemaRestaurante.Services;
using SistemaRestaurante.Utils;
using SistemaRestaurante.Validations;
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
            CarregarComanda();

            if (comandaService.ComandaAtual != null)
            {
                CarregarItens();

                lblTotal.Text = comandaService.ComandaAtual.Total.ToString("C");
            }

            AtualizarTela();
        }

        private void CarregarComanda() // carrega informações de tipo e numero da camanda
        {
            cbNumero.Text = comandaService.ComandaAtual.Numero == 0
                ? ""
                : comandaService.ComandaAtual.Numero.ToString();

            rbMesa.Checked = comandaService.ComandaAtual.Tipo == "Mesa";
            rbViagem.Checked = comandaService.ComandaAtual.Tipo == "Viagem";

            int idPedido = comandaService.ComandaAtual.IdPedido;

            lblNumeroPedido.Text = $"Pedido #{idPedido:D4}";
        }
        private void AtualizarTela() // atualiza itens e valor da comanda atual
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = comandaService.ComandaAtual.Itens;

            lblTotal.Text = comandaService.ComandaAtual.Total.ToString("C");

            btnFinalizarPedido.Visible = comandaService.ComandaAtual.Id > 0 && comandaService.ComandaAtual.Itens.Count > 0;
        }

        private void CarregarCb() // lista de produtos
        {
            cbProduto.DataSource = BancoFake.Produtos;
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "Id";

            cbProduto.SelectedIndex = -1;
            cbProduto.Text = "";
        }
        private void cbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudQuantidade.Focus();
                nudQuantidade.Select(0, nudQuantidade.Text.Length);

                e.SuppressKeyPress = true;
            }
        }
        private void CarregarItens() // itens da comanda que foi aberta
        {
            dgvProdutos.DataSource = comandaService.ComandaAtual;
        }
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            FrmPagamento frm = new FrmPagamento(comandaService);

            if(frm.ShowDialog() == DialogResult.OK)
            {
                PedidoSalvo?.Invoke();
            }
        }

        public event Action PedidoSalvo;
        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            comandaService.ComandaAtual.Tipo = rbMesa.Checked ? "Mesa" : rbViagem.Checked ? "Viagem" : null;

            comandaService.ComandaAtual.Numero = int.TryParse(cbNumero.Text, out int numConvertido) ? numConvertido : (int?)null;

            comandaService.ComandaAtual.Status = "Aberta";


            if (!ComandaValidation.Validar(comandaService.ComandaAtual))
            {
                return;
            }

            comandaService.SalvarComanda();

            PedidoSalvo?.Invoke();
        }

        public event Action PedidoCancelado;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Mensagens.Confirmacao("Deseja cancelar as alterações?") == true)
            {
                comandaService.Cancelar();

                PedidoCancelado?.Invoke();
            }
        }


        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = (Produto)cbProduto.SelectedItem;
            int quantidade = (int)nudQuantidade.Value;

            if (!ProdutoValidation.ProdutoSelecionado(produto, quantidade))
            {
                return;
            }

            comandaService.AdicionarProduto(produto, quantidade);
            AtualizarTela();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvProdutos.Columns[e.ColumnIndex].Name == "colRemover")
            {
                ItemPedido item = (ItemPedido)dgvProdutos.Rows[e.RowIndex].DataBoundItem;

                comandaService.RemoverProduto(item);
                AtualizarTela();
            }
        }

    }
}
