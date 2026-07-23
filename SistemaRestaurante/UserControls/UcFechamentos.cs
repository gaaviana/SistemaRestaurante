using SistemaRestaurante.Data;
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
        public UcFechamentos()
        {
            InitializeComponent();
            dgvRelatorios.AutoGenerateColumns = false;

            dgvRelatorios.DataSource = BancoFake.fechamentos;
        }
    }
}
