using SistemaRestaurante.Data;
using SistemaRestaurante.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRestaurante.Models
{

    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Categorias Categoria { get; set; }

        public decimal Preco { get; set; } // tinha um operador de nulo - ?

        public Produto()
        {
        }

        public Produto(string nome, Categorias categoria, decimal preco)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }
    }
}
