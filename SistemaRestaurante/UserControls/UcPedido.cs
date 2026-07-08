using SistemaRestaurante.Forms;
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
        public UcPedido()
        {
            InitializeComponent();
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            FrmPagamento frm = new FrmPagamento();
            frm.ShowDialog();
        }
    }
}
