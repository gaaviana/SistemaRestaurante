using System.Windows.Forms;

namespace SistemaRestaurante.Utils
{
    public static class Mensagens
    {
        public static void Sucesso(string mensagem)
        {
            MessageBox.Show(
                mensagem,
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void Erro(string mensagem)
        {
            MessageBox.Show(
                mensagem,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void Alerta(string mensagem)
        {
            MessageBox.Show(
                mensagem,
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static bool Confirmacao(string mensagem)
        {
            DialogResult resultado = MessageBox.Show(
                mensagem,
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return resultado == DialogResult.Yes;
        }
    }
}