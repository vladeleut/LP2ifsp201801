using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1E02_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int MAX = 10;
            ///receba 10 números
            int[] vetor = new int[MAX];
            for (int i = 0; i < MAX; i++)
            {
                Console.Write("Insira o {0}º número: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }
            //FuncsAux.OrdenaVetor(vetor);
            Array.Sort(vetor);
            int op;
            do
            {
                Console.WriteLine("Os números inseridos foram:");
                for (int i=0; i<MAX; i++)
                {
                    Console.Write("[ " + vetor[i] + " ]");
                }

                Console.WriteLine("\nEscolha a opção desejada: ");
                Console.WriteLine("1. Imprimir a média dos valores; ");
                Console.WriteLine("2. imprimir a mediana dos valores; ");
                Console.WriteLine("3. Imprimir os números em ordem crescente;");
                Console.WriteLine("4. Imprimir os números em ordem decrescente;");
                Console.WriteLine("0. Sair.");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Até logo!");
                        break;
                    case 1:
                        double soma=0;
                        for (int i=0; i<MAX; i++)
                            soma += vetor[i];
                        Console.WriteLine("A média dos valores inseridos é "+ Math.Round(soma/MAX, 2));
                        FuncsAux.Continua(); break;
                    case 2:
                        Console.Write("A mediana dos valores inseridos é ");
                        //obs:o código inacessível muda dependendo se MAX é par ou impar.
                        if( (MAX % 2) == 0)//ou seja, se o número for par
                        {
                            Console.WriteLine((double)(vetor[(MAX / 2)-1] + vetor[MAX / 2])/2);
                        }                                              //tem q ser menos 1 pois começa no zero!! lembrar disso.
                        else
                        {
                            Console.WriteLine((int)vetor[MAX / 2]);
                        }
                        FuncsAux.Continua(); break;
                    case 3:
                        for (int i = 0; i < MAX; i++)
                        {
                            Console.Write("[ " + vetor[i] + " ]");
                            if (i == MAX-1)
                                Console.WriteLine();
                        }
                        FuncsAux.Continua(); break;
                    case 4:
                        for (int i = MAX-1; i >=0; i--)
                        {
                            Console.Write("[ " + vetor[i] + " ]");
                            if (i == 0)
                                Console.WriteLine();
                        }
                        FuncsAux.Continua(); break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (op != 0);
        }
    }
}
