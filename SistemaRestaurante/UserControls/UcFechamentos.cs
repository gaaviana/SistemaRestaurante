using SistemaRestaurante.Data;
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
    public partial class UcFechamentos : UserControl
    {
        private FechamentoService fechamentoService = new FechamentoService();
        public UcFechamentos()
        {
            InitializeComponent();
            dgvRelatorios.AutoGenerateColumns = false;

            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
                dgvRelatorios.DataSource = null;
                dgvRelatorios.DataSource = fechamentoService.ListarFechamento();

        }
    }
}
