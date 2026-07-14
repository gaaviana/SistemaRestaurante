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

            if(!ProdutoValidation.Validar(produto))
                return;

            if (produtoSelecionado == null)
            {
                produtoService.Cadastrar(produto);
            }
            else
            {
                produtoService.Editar(produtoSelecionado.Id, produto);
            }
                this.DialogResult = DialogResult.OK;
                this.Close();
        }

    }
}
