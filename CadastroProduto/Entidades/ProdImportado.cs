using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProduto.Entidades
{
    class ProdImportado : Produto
    {
        public double Taxa { get; set; }

        public ProdImportado()
        {
        }

        public ProdImportado(string nome, double preco, double taxa) : base (nome, preco)
        {
            Taxa = taxa;
        }

        public double Total()
        {
            return Preco + Taxa;
        }

        public override string ToString()
        {
            return $"{Nome} ${Total():F2} (Custo em taxa: ${Taxa:F2})";
        }
    }
}
