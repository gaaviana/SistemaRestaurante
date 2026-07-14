using SistemaRestaurante.Models;
using SistemaRestaurante.Utils;
using System.Collections.Generic;

namespace SistemaRestaurante.Validations
{
    public class ProdutoValidation
    {
        public static bool Validar(Produto produto)
        {
            if (string.IsNullOrWhiteSpace(produto.Nome))
            {
                Mensagens.Erro("O nome do produto é obrigatório.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(produto.Categoria))
            {
                Mensagens.Erro("Selecione uma categoria");
                return false;
            }

            if (produto.Preco == null)
            {
                Mensagens.Erro("O preço deve ser um número válido (ex: 10,50).");
                return false;
            }
            else if (produto.Preco <= 0)
            {
                Mensagens.Erro("O preço deve ser maior que zero.");
                return false;
            }

            return true;
        }

        public static bool ProdutoSelecionado(Produto produto, int qtd)
        {
            if (produto == null)
            {
                Mensagens.Erro("Selecione um produto");
                return false;
            }

            if (qtd <= 0)
            {
                Mensagens.Erro("Informe a quantidade");
                return false;
            }

            return true;
        }
    }
}