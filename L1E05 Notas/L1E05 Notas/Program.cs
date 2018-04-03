using System;
/*
Solicite três notas de um aluno, 
imprima a média e uma mensagem:
    se o aluno foi aprovado, reprovado ou está de prova final. 
    
    O aluno “Aprovado” deve possuir média igual ou superior a 6,0. 
    O aluno de “Prova final” deve possuir média menor que 6,0 e maior ou igual a 4,0. 
    O aluno com média inferior a 4,0 está “Reprovado”.
*/
namespace L1E05_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                const int MAX = 3;
                double[] notas = new double[MAX];
                double[] stats = new double[2];

                for(int i=0; i < MAX; i++)
                {
                    Console.Write("Insira a {0} nota: ", i+1);
                    notas[i] = double.Parse(Console.ReadLine());
                    stats[0] += notas[i];//soma das notas
                }
                stats[1] = stats[0] / MAX;//média das notas

                Console.Clear();
                Console.Write("A média do aluno é " + Math.Round(stats[1])+"; Status: ");

                if (stats[1]<4)
                {
                    Console.Write("Reprovado");
                }
                else if (stats[1]<=6)
                {
                    Console.Write("Prova Final");
                }
                else
                {
                    Console.Write("Aprovado");
                }

                Console.Read();
            }
        }
    }

}