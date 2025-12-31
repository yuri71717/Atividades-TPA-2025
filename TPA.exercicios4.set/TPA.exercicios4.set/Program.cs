using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TPA.exercicios4.set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            int valor = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = valor++;
                }
            }

            Console.WriteLine("Valores da diagonal principal:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Valores da diagonal secundária:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(matriz[i, 4 - i] + " ");
            }
            Console.WriteLine();
        }
    }
}
