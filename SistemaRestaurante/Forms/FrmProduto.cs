using SistemaRestaurante.Models;
using SistemaRestaurante.Services;
using SistemaRestaurante.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaRestaurante.Forms
{
    public partial class FrmProduto : Form
    {
        ProdutoService produtoService = new ProdutoService();
        private Produto produtoSelecionado;
        public FrmProduto()
        {
            InitializeComponent();
        }
        public FrmProduto(Produto produto)
        {
            InitializeComponent();

            produtoSelecionado = produto;
            
            CarregarProdutoEdit();
        }

        private void CarregarProdutoEdit()
        {
            lblTitulo.Text = "Atuzalizar Produto";
            btnSalvar.Text = "Atualizar";
            txtNome.Text = produtoSelecionado.Nome;
            cbCategoria.Text = produtoSelecionado.Categoria;
            txtPreco.Text = produtoSelecionado.Preco.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            decimal? preco = decimal.TryParse(txtPreco.Text, out decimal precoConvertido) ? precoConvertido : (decimal?)null;

            Produto produto = new Produto(txtNome.Text, cbCategoria.Text, preco);

            List<string> erros = ProdutoValidation.Validar(produto);
            
            if (erros.Any())
            {
                MessageBox.Show(string.Join("\n", erros), "Erros de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (produtoSelecionado == null)
            {
                produtoService.Cadastrar(produto);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Produto produtoEdit = new Produto(produto.Nome, produto.Categoria, produto.Preco);
                erros = ProdutoValidation.Validar(produto);

                if (erros.Any())
                {
                    MessageBox.Show(string.Join("\n", erros), "Erros de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                produtoService.Editar(produtoSelecionado.Id, produtoEdit);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
