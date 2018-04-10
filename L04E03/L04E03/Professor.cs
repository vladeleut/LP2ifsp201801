using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04E03
{
    class Professor: Funcionario
    {
        private String titulacao;

        //código faltante:
        public Professor(int id, string nome, string titulo): base(id, nome)
        {
            this.titulacao = titulo;
        }

        public override string ToString()
        {
            return Nome + " - " + Titulacao;
        }
        //até aqui


        //diferente da lista:
        public String Titulacao { get { return titulacao; } set { titulacao = value; } }

        
    }
}
