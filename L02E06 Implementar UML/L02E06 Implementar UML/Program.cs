using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02E06_Implementar_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor empresa = new Fornecedor();
            empresa.Cadastrar(empresa);


        }
    }
}
