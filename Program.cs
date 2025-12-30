using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double maior, menor;

            if (valor1 > valor2)
            {
                maior = valor1;
                menor = valor2;
            }
            else
            {
                maior = valor2;
                menor = valor1;
            }

            double resultado = maior - menor;

            Console.WriteLine($"A diferença entre o maior ({maior}) e o menor ({menor}) é: {resultado}");

            Console.ReadKey();
        }
    }
}
           
    



    