using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpa.out3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] clientes = new string[4];

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.Write($"Digite o nome do cliente {i + 1}: ");
                clientes[i] = Console.ReadLine();
            }

            Array.Sort(clientes);

            Console.WriteLine("\nNomes dos clientes em ordem alfabética:");
            foreach (string nome in clientes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
