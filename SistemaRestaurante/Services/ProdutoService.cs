using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.UserControls;
using SistemaRestaurante.Utils;
using SistemaRestaurante.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Services
{
    public class ProdutoService
    {
        public void Cadastrar(Produto produto)
        {
            BancoFake.Produtos.Add(produto);
        }

        public void Editar(int id, Produto produtoEdit)
        {
            Produto produtoSelecionado = BancoFake.Produtos.FirstOrDefault(p => p.Id == id);

            if (produtoSelecionado == null)
            {
                Mensagens.Erro("O produto selecionado não existe");
            }

            produtoSelecionado.Nome = produtoEdit.Nome;
            produtoSelecionado.Categoria = produtoEdit.Categoria;
            produtoSelecionado.Preco = produtoEdit.Preco;

            Mensagens.Sucesso("Produto Atualizado");
        }

        public void Excluir(int id)
        {
            Produto produtoExcluir = BancoFake.Produtos.FirstOrDefault(p => p.Id == id);

            if (produtoExcluir == null)
            {
                Mensagens.Erro("O produto selecionado não existe");
            }
            else
            {
                bool res = Mensagens.Confirmacao("Tem certeza que deseja excluir este produto?");
                if (res == true)
                {
                     BancoFake.Produtos.Remove(produtoExcluir);
                }
            }
        }
    }
}
