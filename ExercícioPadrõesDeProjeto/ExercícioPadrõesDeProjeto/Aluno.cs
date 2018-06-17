using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioPadrõesDeProjeto
{
    class Aluno
    {
        private int codigo;
        private string nome;
        private DateTime dataNasc;
        private string cpf;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }
            set
            {
                dataNasc = value;
            }
        }
        public string CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

    }
}
