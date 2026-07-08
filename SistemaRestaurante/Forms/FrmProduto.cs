using SistemaRestaurante.Models;
using SistemaRestaurante.Services;
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
        private Produto produtoEdit;
        public FrmProduto()
        {
            InitializeComponent();
        }
        public FrmProduto(Produto produto)
        {
            InitializeComponent();

            produtoEdit = produto;
            
            CarregarProdutoEdit();
        }

        private void CarregarProdutoEdit()
        {
            lblTitulo.Text = "Atuzalizar Produto";
            btnSalvar.Text = "Atualizar";
            txtNome.Text = produtoEdit.Nome;
            cbCategoria.Text = produtoEdit.Categoria;
            txtPreco.Text = produtoEdit.Preco.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string categoria = cbCategoria.Text;
            decimal preco = decimal.Parse(txtPreco.Text);

            if (produtoEdit == null)
            {

                produtoService.Cadastrar(nome, categoria, preco);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                produtoService.Editar(produtoEdit.Id, nome, categoria, preco);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
           
        }

    }
}
