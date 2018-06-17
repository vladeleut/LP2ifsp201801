using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioPadrõesDeProjeto
{
    class Emprestimo
    {
        private DateTime dataRetirada;
        private DateTime dataDev;
        private int codigo;
        private Aluno aluno;
        private Livro livro;

        public DateTime DataRet { get { return dataRetirada; } set { dataRetirada = value; } }
        public DateTime DataDev { get { return dataDev; } set { dataDev = value; } }
        //        public Type nomevar { get { return blablabla; } set { blablabla = value; } }
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public Aluno Aluno { get { return aluno; } set { aluno = value; } }
        public Livro Livro { get { return livro; } set { livro = value; } }
    }
}
