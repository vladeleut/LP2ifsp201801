using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioPadrõesDeProjeto
{
    class Livro
    {
        private int codigo;
        private string titulo;
        private string autor;

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Autor { get { return autor; } set { autor = value; } }
    }
}
