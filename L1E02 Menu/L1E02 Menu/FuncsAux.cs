using System;

namespace L1E02_Menu
{
    class FuncsAux
    {
        static public void Continua()
        {
            const string CONTINUA = "Pressione qualquer tecla para continuar.\n";
            Console.Write(CONTINUA);
            Console.ReadKey();
            Console.Clear();
        }
        /*
        public static void OrdenaVetor(int[] vetor)
        {
            int aux;

                do
                {
                    aux = -1;
                    for (int i = 0; i < vetor.Length - 1; i++)
                    {
                        if (vetor[i] > vetor[i + 1])
                        {//se a posição seguinte é menor, troca
                            Console.WriteLine(vetor[i]);
                            aux = vetor[i];
                            vetor[i] = vetor[i + 1];
                            vetor[i + 1] = aux;
                        Console.WriteLine(vetor[i]);
                        }
                    }
                } while (aux != -1); //pára de executar quando não há nenhuma troca 
            }
        */
    }
        
 }

