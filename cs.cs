using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[200];
            Random random = new Random();
            int opcao, menor = int.MaxValue, maior = int.MinValue, pesquisar, media, soma = 0, cont = 0, quantMedia = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = random.Next(0, 100);
                soma += notas[i];
                cont++;
            }
            Console.WriteLine("Opções");
            Console.WriteLine("1. Mostrar menor nota");
            Console.WriteLine("2. Mostrar maior nota");
            Console.WriteLine("3 Pesquisar nota");
            Console.WriteLine("4 Mostrar média das notas e quantidade de notas acima da média");
            Console.WriteLine("5 Sair");
            do
            {
                Console.WriteLine("Digite uma das opções");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] < menor)
                        {
                            menor = notas[i];
                        }
                    }
                    Console.WriteLine("Menor nota: " + menor);
                }
                else if (opcao == 2)
                {
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] > maior)
                        {
                            maior = notas[i];
                        }
                    }
                    Console.WriteLine("Maior nota: " + maior);
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Digite uma nota para pesquisar no vetor:");
                    pesquisar = int.Parse(Console.ReadLine());

                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] == pesquisar)
                            Console.WriteLine("A nota " + pesquisar + " está na posição: " + i);

                    }
                }
                else if (opcao == 4)
                {
                    media = soma / cont;
                    for (int i = 0; i < notas.Length; i++)
                    {
                        if (notas[i] > media)
                        {
                            media = notas[i];
                            quantMedia++;
                        }
                    }
                    Console.WriteLine("Média: " + media);
                    Console.WriteLine("Quantidade de notas acima da média: " + quantMedia);
                }
                else
                {
                    Console.WriteLine("Saiu!");
                }

            } while (opcao != 5);
            Console.ReadLine();
        }
    }
}
