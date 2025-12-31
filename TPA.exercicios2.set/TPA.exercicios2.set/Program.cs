using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace TPA.exercicios2.set
{
    internal class Program
    {
        class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }

        static void Main(string[] args)
        {
            var produtos = new List<Produto>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o nome do produto {i + 1}: ");
                string nome = Console.ReadLine();

                decimal preco;
                while (true)
                {
                    Console.Write($"Digite o preço do produto {i + 1}: ");
                    if (decimal.TryParse(Console.ReadLine(), out preco) && preco >= 0)
                        break;
                    Console.WriteLine("Preço inválido. Tente novamente.");
                }

                produtos.Add(new Produto { Nome = nome, Preco = preco });
            }

            Console.Write("\nDigite um valor para pesquisa: ");
            decimal valorPesquisa;
            while (!decimal.TryParse(Console.ReadLine(), out valorPesquisa) || valorPesquisa < 0)
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                Console.Write("Digite um valor para pesquisa: ");
            }

            Console.WriteLine("\nProdutos com preço até R$ " + valorPesquisa.ToString("F2") + ":");
            foreach (var produto in produtos)
            {
                if (produto.Preco <= valorPesquisa)
                    Console.WriteLine($"- {produto.Nome}: R$ {produto.Preco:F2}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
