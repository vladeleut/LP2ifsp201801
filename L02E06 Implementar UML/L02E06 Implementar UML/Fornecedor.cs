using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02E06_Implementar_UML
{
    class Fornecedor
    {
        private int codigo;
        private String nome, endereco, bairro, cidade, uf, cep, telefone;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value > 0 ? value : 0; }
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
       
            public String UF
        {
            get { return uf; }
            set { uf = value; }
        }
        public String CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


        public void Cadastrar(Fornecedor fornecedor)
        {
            Console.WriteLine("Insira os dados do fornecedor: ");
            Console.Write("Código: ");
            fornecedor.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            fornecedor.Nome = Console.ReadLine();
            Console.Write("Endereço (Rua, nº: ");
            fornecedor.Endereco = Console.ReadLine();
            Console.Write("Bairro: ");
            fornecedor.Bairro = Console.ReadLine();
            Console.Write("Cidade: ");
            fornecedor.Cidade = Console.ReadLine();
            Console.Write("UF: ");
            fornecedor.UF = Console.ReadLine();
            Console.Write("CEP: ");
            fornecedor.CEP = Console.ReadLine();
            Console.Write("Telefone: ");
            fornecedor.Telefone = Console.ReadLine();
            
        }



    }
}
