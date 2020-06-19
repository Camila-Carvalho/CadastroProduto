using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProduto.Entidades
{
    class ProdUsado : Produto
    {
        public DateTime DataFab { get; set; }

        public ProdUsado()
        {
        }

        public ProdUsado(string nome, double preco, DateTime dataFab) : base(nome, preco)
        {
            DataFab = dataFab;
        }

        public override string ToString()
        {
            return $"{Nome} (usado) ${Preco:F2} (Fabricado em: {DataFab:dd/MM/yyyy})";
        }
    }
}
