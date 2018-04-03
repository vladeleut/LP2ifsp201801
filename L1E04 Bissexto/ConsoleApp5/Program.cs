using System;

/*
Escreva um programa que receba um número, 
calcule se ele é bissexto ou não e imprima na tela. 
Um ano é bissexto se 
é múltiplo de quatro, não é múltiplo de 100 (1900 não é bissexto) 
ou é múltiplo de 400 (2000 é bissexto).
*/


namespace L1E04Bissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um ano para descobrir se ele é bissexto: ");
            int ano = int.Parse(Console.ReadLine());

            if(ano%400 == 0)
            {
                Console.Clear(); 
                Console.Write("O ano {0} é bissexto.", ano);
            }else if (ano%4 == 0 && ano%100 != 0)
            {
                Console.Clear();
                Console.Write("O ano {0} é bissexto.", ano);
            }
            else
            {
                Console.Clear();
                Console.Write("O ano {0} NÃO é bissexto.", ano);
            }
            Console.Read();
        }
    }
}
