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
    public partial class UcCaixa : UserControl
    {
        private CaixaService caixaService = new CaixaService();
        public UcCaixa()
        {
            InitializeComponent();

            dgvCaixa.AutoGenerateColumns = false;
            AtualizarTabela();
        }

        public void AtualizarTabela()
        {
            dgvCaixa.DataSource = null;
            dgvCaixa.DataSource = caixaService.ObterVendas();
        }


    }
}
