using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01E06_Porcentagem_Caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma frase qualquer: ");
            string frase = Console.ReadLine();

            int contVogal = 0, contConsoante = 0;
            double soma;

            int[] vogais = { 65, 69, 73, 79, 85, 97, 101, 105, 111, 117 };
                            //vogais maiúsculas e minúsculas na tabela ASCII

            foreach (char c in frase)
            {
                if((c >= 65 && c <= 90) | (c >= 97 && c <= 122))
                    //vou considerar apenas as letras. espaços, caracteres especiais e números não contam.
                {
                    for (int i=0; i< vogais.Length; i++)
                    {
                        if ((int)c == vogais[i])
                        {
                            //Console.WriteLine(c + "somei uma V");
                            contVogal++;
                            break;
                        }else if(i == (vogais.Length - 1))
                        {
                            //Console.WriteLine(c + "somei uma C");
                            contConsoante++;
                        }
                    }
                }
            }
            soma = contConsoante + contVogal;
            Console.Clear();
            Console.WriteLine("Na frase \"" + frase + "\" existem:\n {0} Vogais ({1}%) e {2} consoantes ({3}%)", 
                contVogal, Math.Round((contVogal/soma*100) ,2), contConsoante, Math.Round(contConsoante / soma * 100, 2));
            Console.Read();
        }
    }
}
//letras maiúsculas: 65-90
          // vogais: 65,69,73,79,85
//letras minúsculas: 97-122
       //consoantes: 97,101, 105, 111, 117