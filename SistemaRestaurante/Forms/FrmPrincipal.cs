using SistemaRestaurante.UserControls;

namespace SistemaRestaurante
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
            
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            UcProdutos produtos = new UcProdutos();

            produtos.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(produtos);
        }
        private void btnComandas_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            UcComandas comandas = new UcComandas();

            comandas.NovoPedido += AbrirPedido;

            comandas.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(comandas);
        }

        private void AbrirPedido()
        {
            pnlConteudo.Controls.Clear();

            UcPedido pedido = new UcPedido();

            pedido.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(pedido);
        }

    }
}
