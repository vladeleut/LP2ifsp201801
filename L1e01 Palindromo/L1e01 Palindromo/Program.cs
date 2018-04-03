using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1E01_Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira uma palavra ou frase: ");
            string palavra = Console.ReadLine(); //recebe palavra ou frase do usuário e armazena em "palavra"
            palavra = palavra.Replace(" ", "").ToLower();//remove espaços usando o método "replace" e deixa tudo em minúsculo com ToLower

            string palavrainvertida = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
                
                palavrainvertida += palavra[i];//caminha a string palavra do fim para o começo e armazena cada letra, 
                                               //em ordem invertida.

            /*
            Console.WriteLine("Palavra ou frase  inserida: " + palavra);
            Console.WriteLine("Palavra ou frase invertida: " + palavrainvertida);
            */

            if (palavra.Equals(palavrainvertida))
            //if(String.Compare(palavra.ToLower(), palavrainvertida.ToLower())==0)
            {
                Console.WriteLine("Palíndromo encontrado.");
            }
            else
            {
                Console.WriteLine("Palíndromo NÃO encontrado.");
            }


            Console.Read();
        }
    }
}
