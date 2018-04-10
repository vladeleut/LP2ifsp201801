using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04E03
{
    class Funcionario
    {
        private int id;
        private String nome;
        public Funcionario(int id, String nome) { Id = id; Nome = nome; }
        public int Id { get; set; }
        public String Nome { get; set; }
    }
}
