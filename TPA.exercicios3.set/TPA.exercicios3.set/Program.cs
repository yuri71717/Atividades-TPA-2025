using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TPA.exercicios3.set
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int linhas = 3;
            int colunas = 5;
            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine("Digite 15 números inteiros para preencher a matriz 3x5:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Elemento [{i + 1},{j + 1}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                    {
                        Console.Write("Valor inválido. Digite um número inteiro: ");
                    }
                }
            }
            Console.WriteLine("\nSoma dos valores de cada linha:");
            for (int i = 0; i < linhas; i++)
            {
                int soma = 0;
                for (int j = 0; j < colunas; j++)
                {
                    soma += matriz[i, j];
                }
                Console.WriteLine($"Linha {i + 1}: {soma}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
