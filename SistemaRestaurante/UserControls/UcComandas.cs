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
        public UcComandas()
        {
            InitializeComponent();
        }

        public event Action NovoPedido;

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            NovoPedido?.Invoke();
        }
    }
}
