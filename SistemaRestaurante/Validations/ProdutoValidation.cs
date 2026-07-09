using SistemaRestaurante.Models;
using System.Collections.Generic;

namespace SistemaRestaurante.Validations
{
    public class ProdutoValidation
    {
        public static List<string> Validar(Produto produto)
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrWhiteSpace(produto.Nome))
                erros.Add("O nome do produto é obrigatório.");

            if (string.IsNullOrWhiteSpace(produto.Categoria))
                erros.Add("Selecione uma categoria.");

            if (produto.Preco == null)
            {
                erros.Add("O preço deve ser um número válido (ex: 10,50).");
            }
            else if (produto.Preco <= 0)
            {
                erros.Add("O preço deve ser maior que zero.");
            }

            return erros;
        }
    }
}