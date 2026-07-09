using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.UserControls;
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
                MessageBox.Show("error editar");
            }

            produtoSelecionado.Nome = produtoEdit.Nome;
            produtoSelecionado.Categoria = produtoEdit.Categoria;
            produtoSelecionado.Preco = produtoEdit.Preco;

            MessageBox.Show("Produto Atualizado");
        }

        public void Excluir(int id)
        {
            Produto produtoExcluir = BancoFake.Produtos.FirstOrDefault(p => p.Id == id);

            if (produtoExcluir == null)
            {
                MessageBox.Show("error excluir");
            }
            else
            {
                DialogResult res = MessageBox.Show( "Tem certeza que deseja excluir este produto?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                     BancoFake.Produtos.Remove(produtoExcluir);
                }
            }
        }
    }
}
