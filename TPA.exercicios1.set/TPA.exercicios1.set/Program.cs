using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA.exercicios1.set
{
    internal class Program
    {
        
        private static int[] numeros = new int[15];

        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros nas posições pares:");

            for (int i = 0; i < 15; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Posição {i}: {numeros[i]}");
                }
            }
        }
    }

}
    
