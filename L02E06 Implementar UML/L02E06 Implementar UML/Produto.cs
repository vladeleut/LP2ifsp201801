using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02E06_Implementar_UML
{
    class Produto
    {
        private int codigo, codFornecedor, estoque;
        private String nome;
        private double valor;

        public int Codigo
        {
            get {return codigo; }
            set {codigo = value>=0 ? value : 0; }
        }
        public int CodFornecedor
        {
            get {return codFornecedor; }
            set {codFornecedor = value; }
        }
        public int Estoque
        {
            get {return estoque; }
            set {estoque = value; }
        }
        public String Nome
        {
            get {return nome; }
            set {nome = value != "" ? value : "N/A"; }
        }
        public double Valor
        {
            get {return valor; }
            set {valor = value >=0 ? value : 0; }
        }

        public void Cadastrar(Produto produto)
        {
            //codigo de cadastro aqui
        }
        public void Editar (Produto produto)
        {
            //codigo de edição aqui
        }
        public void ExcluirEstoque(int qtde)
        {
            //código de exclusão aqui
        }
    }
}
