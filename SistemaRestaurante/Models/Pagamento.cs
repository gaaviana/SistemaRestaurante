public class Pagamento
{
    public int Id { get; set; }
    public FormaPagamento FormaPagamento { get; set; }
    public decimal Valor { get; set; }
    public decimal ValorRecebido { get; set; }
    public DateTime Data { get; set; }
    public decimal Troco
    {
        get
        {
            if (FormaPagamento != FormaPagamento.Dinheiro)
                return 0;

            return ValorRecebido - Valor;
        }
    }
}