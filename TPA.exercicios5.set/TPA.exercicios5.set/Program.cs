using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA.exercicios5.set
{
   

class Program
        {
            static void Main()
            {
                string[] alunos = new string[10];
                double[,] notas = new double[10, 3]; 
                double[] medias = new double[10]; 

                alunos[0] = "Miguel";
                notas[0, 0] = 6.0; notas[0, 1] = 7.0; notas[0, 2] = 8.0;

                alunos[1] = "Duduzinho";
                notas[1, 0] = 7.0; notas[1, 1] = 6.0; notas[1, 2] = 8.0;

                alunos[2] = "Julia";
                notas[2, 0] = 9.5; notas[2, 1] = 7.5; notas[2, 2] = 5.5;

                alunos[3] = "Sophia";
                notas[3, 0] = 8.5; notas[3, 1] = 9.5; notas[3, 2] = 7.5;

                alunos[4] = "Lívia";
                notas[4, 0] = 3.0; notas[4, 1] = 7.0; notas[4, 2] = 5.0;

                alunos[5] = "Lorena";
                notas[5, 0] = 7.5; notas[5, 1] = 5.5; notas[5, 2] = 6.5;

                alunos[6] = "Vitor";
                notas[6, 0] = 6.0; notas[6, 1] = 8.0; notas[6, 2] = 10.0;

                alunos[7] = "Mariana";
                notas[7, 0] = 7.0; notas[7, 1] = 8.0; notas[7, 2] = 9.0;

                alunos[8] = "Maria Luiza";
                notas[8, 0] = 6.0; notas[8, 1] = 5.0; notas[8, 2] = 4.0;

                alunos[9] = "Ana Luiza";
                notas[9, 0] = 6.0; notas[9, 1] = 5.0; notas[9, 2] = 7.0;

                for (int i = 0; i < 10; i++)
                {
                    medias[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                }

                for (int i = 0; i < 10; i++)
                {
                    if (medias[i] >= 7.0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; 
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                    }

                    Console.WriteLine($"Aluno: {alunos[i]}");
                    Console.WriteLine($"Notas: {notas[i, 0]:0.0}, {notas[i, 1]:0.0}, {notas[i, 2]:0.0}");
                    Console.WriteLine($"Média: {medias[i]:0.0}");
                    if (medias[i] >= 7.0)
                    {
                        Console.WriteLine("Situação: Aprovado");
                    }
                    else
                    {
                        Console.WriteLine("Situação: Reprovado");
                    }
                    Console.WriteLine(); 
                }

                
                Console.ResetColor();
            }
        }

    }

