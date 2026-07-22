using System.ComponentModel;

public enum FormaPagamento
{
    [Description("Dinheiro")]
    Dinheiro,

    [Description("Pix")]
    Pix,

    [Description("Cartão Débito")]
    CartaoDebito,

    [Description("Cartão Crédito")]
    CartaoCredito
}