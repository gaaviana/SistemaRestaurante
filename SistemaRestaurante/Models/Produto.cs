using SistemaRestaurante.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{
   
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal? Preco {  get; set; }

        public Produto(string nome, string categoria, decimal? preco)
        {
            Id = GerarProximoId();
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }

        private int GerarProximoId()
        {
            if (BancoFake.Produtos != null && BancoFake.Produtos.Count > 0)
            {
                return BancoFake.Produtos.Max(p => p.Id) + 1;
            }
            return 1;

        }
    }
}
