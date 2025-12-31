using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpa.out4
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] unidadesVendidas = new int[6];
            int total = 0;

            for (int i = 0; i < unidadesVendidas.Length; i++)
            {
                Console.Write($"Digite a quantidade de unidades vendidas do produto {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out unidadesVendidas[i]) || unidadesVendidas[i] < 0)
                {
                    Console.Write("Valor inválido. Digite novamente: ");
                }
                total += unidadesVendidas[i];
            }

            Console.WriteLine($"\nTotal de unidades vendidas: {total}");
        }
    }
}
