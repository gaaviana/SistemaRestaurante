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
    public partial class UcComandas : UserControl
    {
        private ComandaService comandaService = new ComandaService();
        public UcComandas()
        {
            InitializeComponent();
            dgvComandas.AutoGenerateColumns = false;

            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            dgvComandas.DataSource = null;
            dgvComandas.DataSource = comandaService.ComandasAbertas(); 
        }


        public event Action NovoPedido;
        public event Action<Comanda> AbrirComanda;

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            NovoPedido?.Invoke();
        }

        private void dgvComandas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Comanda comanda = (Comanda)dgvComandas.Rows[e.RowIndex].DataBoundItem;

            AbrirComanda?.Invoke(comanda);

        }

    }
}
