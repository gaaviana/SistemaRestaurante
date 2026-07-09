using SistemaRestaurante.Models;
using SistemaRestaurante.Services;
using SistemaRestaurante.UserControls;

namespace SistemaRestaurante
{
    public partial class FrmPrincipal : Form
    {
        private readonly ComandaService comandaService = new ComandaService();
        public FrmPrincipal()
        {
            InitializeComponent();  
            
        }

        private void AbrirTela(Control Tela)
        {
            pnlConteudo.Controls.Clear();

            Tela.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(Tela);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {

            UcProdutos produtos = new UcProdutos();

            AbrirTela(produtos);
        }
        private void btnComandas_Click(object sender, EventArgs e)
        {
            AbrirComandas();

            UcComandas comandas = new UcComandas();

            comandas.NovoPedido += AbrirNovoPedido;

            AbrirTela(comandas);
        }

        private void AbrirNovoPedido()
        {
            comandaService.NovaComanda();

            UcPedido pedido = new UcPedido(comandaService);

            pedido.PedidoSalvo += AbrirComandas;

            AbrirTela(pedido);
        }

        private void AbrirComandas()
        {

            UcComandas comandas = new UcComandas();

            comandas.NovoPedido += AbrirNovoPedido;
            comandas.AbrirComanda += AbrirComandaExistente;

            AbrirTela(comandas);
        }

        private void AbrirComandaExistente(Comanda comanda)
        {
            comandaService.AbrirComanda(comanda);

            UcPedido pedido = new UcPedido(comandaService);

            pedido.PedidoSalvo += AbrirComandas;

            AbrirTela(pedido);
        }

    }
}
