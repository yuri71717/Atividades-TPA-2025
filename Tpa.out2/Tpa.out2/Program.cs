using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Tpa.out2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] diasSemana = { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" };
            int[] vendas = new int[7];

            for (int i = 0; i < diasSemana.Length; i++)
            {
                Console.Write($"Digite a quantidade de vendas realizadas na(o) {diasSemana[i]}: ");
                while (!int.TryParse(Console.ReadLine(), out vendas[i]) || vendas[i] < 0)
                {
                    Console.Write("Valor inválido. Digite novamente: ");
                }
            }

            Console.WriteLine("\nQuantidade de vendas por dia da semana:");
            for (int i = 0; i < diasSemana.Length; i++)
            {
                Console.WriteLine($"{diasSemana[i]}: {vendas[i]} vendas");
            }
        }
    }
}
