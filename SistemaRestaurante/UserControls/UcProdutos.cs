using SistemaRestaurante.Data;
using SistemaRestaurante.Forms;
using SistemaRestaurante.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaRestaurante.UserControls
{
    public partial class UcProdutos : UserControl
    {
        public UcProdutos()
        {
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;

            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = BancoFake.Produtos;
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frm = new FrmProduto();
            frm.ShowDialog();
            AtualizarTabela();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvProdutos.Columns[e.ColumnIndex].Name == "colEditar")
            {
                Produto produto = (Produto)dgvProdutos.Rows[e.RowIndex].DataBoundItem;

                FrmProduto frm = new FrmProduto(produto);
                frm.ShowDialog();
                AtualizarTabela();
            }
        }
    }
}
