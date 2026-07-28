
namespace SistemaRestaurante.Models {
    public class Pagamento
    {
        public int Id { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        public decimal Valor { get; set; }

        public decimal ValorRecebido { get; set; }

        public DateTime Data { get; set; }

        public int ComandaId { get; set; }

        public Comanda Comanda { get; set; }

        public decimal Troco =>
            FormaPagamento == FormaPagamento.Dinheiro
                ? ValorRecebido - Valor
                : 0;

        public Pagamento()
        {
        }

        public Pagamento(FormaPagamento formaPagamento, decimal valor, decimal valorRecebido)
        {
            FormaPagamento = formaPagamento;
            Valor = valor;
            ValorRecebido = valorRecebido;
            Data = DateTime.Now;
        }
    }
}
