using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{

class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Informe um número para calcular o fatorial: ");

                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    long resultado = CalcularFatorial(numero);
                    Console.WriteLine($"O fatorial de {numero} é: {resultado}");
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número inteiro válido.");
                }
            }

            static long CalcularFatorial(int n)
            {
                if (n < 0)
                    throw new ArgumentException("Fatorial não definido para números negativos.");

                if (n == 0 || n == 1)
                    return 1;

                long fatorial = 1;
                for (int i = 2; i <= n; i++)
                {
                    fatorial *= i;
                }
                return fatorial;
            }
        }

    }

