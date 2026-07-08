using SistemaRestaurante.Data;
using SistemaRestaurante.Models;
using SistemaRestaurante.UserControls;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Services
{
    public class ProdutoService
    {
        public void Cadastrar(string nome, string categoria, decimal preco)
        {
            int id = 1;
            if (BancoFake.Produtos.Count > 0)
            {
                id = BancoFake.Produtos.Max(p => p.Id) + 1;
            }

            Produto produto = new Produto(id, nome, categoria, preco);
            BancoFake.Produtos.Add(produto);
        }

        public void Editar(int id, string nome, string categoria, decimal preco)
        {
            Produto produtoEdit = BancoFake.Produtos.FirstOrDefault(p => p.Id == id);

            if (produtoEdit == null)
            {
                MessageBox.Show("error editar");
            }

            produtoEdit.Nome = nome;
            produtoEdit.Categoria = categoria;
            produtoEdit.Preco = preco;

            MessageBox.Show("Produto Atualizado");
        }

        public void Excluir()
        {

        }
    }
}
