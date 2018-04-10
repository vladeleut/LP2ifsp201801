using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04E03
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Professor(1, "Joao", "Doutor");
            Funcionario f2 = new Professor(2, "Jose", "Mestre");
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.Read();
        }
    }
}
