using System;
using System.Collections.Generic;
using CadastroProduto.Entidades;

namespace CadastroProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            List<Produto> lista = new List<Produto>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Produto nº {i}:");
                Console.Write("Comum, usado ou importado? (c/u/i)");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                if (resp == 'c' || resp == 'C')
                {
                    lista.Add(new Produto(nome, preco)); //para adicionar o produto na lista
                }
                else if (resp == 'u' || resp == 'U')
                {
                    Console.Write("Data fabricação: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdUsado(nome,preco,data));
                }
                else
                {
                    Console.Write("Taxa aduaneira: ");
                    double taxa = double.Parse(Console.ReadLine());
                    lista.Add(new ProdImportado(nome, preco, taxa));
                }
            }

            Console.WriteLine();
            Console.WriteLine("ETIQUETAS DE PREÇO:");
            foreach (Produto obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
