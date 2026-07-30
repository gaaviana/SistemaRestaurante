using Microsoft.EntityFrameworkCore;
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
        private readonly RestauranteContext context;

        public ProdutoService()
        {
            context = new RestauranteContext();
        }

        public List<Produto> Listar() // metodo para listar produtos do banco de dados
        {
            using (var context = new RestauranteContext())
            {
                return context.Produtos.ToList();
            }
        }
        public void Cadastrar(Produto produto)
        {
            using (var context = new RestauranteContext())
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
            }

            //BancoFake.Produtos.Add(produto);
        }

        public void Editar(int id, Produto produtoEdit)
        {
            using (var context = new RestauranteContext())
            {
                Produto produtoSelecionado = context.Produtos.Find(id);

                if (produtoSelecionado == null)
                {
                    Mensagens.Erro("O produto selecionado não existe");
                    return;
                }

                produtoSelecionado.Nome = produtoEdit.Nome;
                produtoSelecionado.Categoria = produtoEdit.Categoria;
                produtoSelecionado.Preco = produtoEdit.Preco;

                context.SaveChanges();

                Mensagens.Sucesso("Produto Atualizado");
            }

            //Produto produtoSelecionado = BancoFake.Produtos.FirstOrDefault(p => p.Id == id);

            //if (produtoSelecionado == null)
            //{
            //    Mensagens.Erro("O produto selecionado não existe");
            //}

            //produtoSelecionado.Nome = produtoEdit.Nome;
            //produtoSelecionado.Categoria = produtoEdit.Categoria;
            //produtoSelecionado.Preco = produtoEdit.Preco;

            //Mensagens.Sucesso("Produto Atualizado");
        }

        public void Excluir(int id)
        {
            using(var context = new RestauranteContext())
            {
                Produto produtoExcluir = context.Produtos.Find(id);

                if (produtoExcluir == null)
                {
                    Mensagens.Erro("O produto selecionado não existe");
                    return;
                }

                bool res = Mensagens.Confirmacao("Tem certeza que deseja excluir este produto?");

                if (!res)
                    return;

                context.Produtos.Remove(produtoExcluir);
                context.SaveChanges();
                Mensagens.Sucesso("Produto excluído!");
            }

            //Produto produtoExcluir = BancoFake.Produtos.FirstOrDefault(p => p.Id == id);

            //if (produtoExcluir == null)
            //{
            //    Mensagens.Erro("O produto selecionado não existe");
            //}
            //else
            //{
            //    bool res = Mensagens.Confirmacao("Tem certeza que deseja excluir este produto?");
            //    if (res == true)
            //    {
            //         BancoFake.Produtos.Remove(produtoExcluir);
            //    }
            //}
        }
    }
}
