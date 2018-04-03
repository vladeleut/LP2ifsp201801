using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02E06_Implementar_UML
{
    class Cliente
    {
        private int codigo;
        private String nome, endereco, bairro, cidade, uf, cep, telefone;
        private long cpf, rg;

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

        public long CPF
        {
            get { return cpf; }
            set { cpf = value > 0 ? value : 0; /*melhorar validação*/}
        }
        public long RG
        {
            get { return rg; }
            set { rg = value > 0 ? value : 0; /*melhorar validação*/}
        }


        public void Cadastrar (Cliente cliente)
        {
            //código de cadastro aqui
        }

        public void Editar(Cliente cliente)
        {
            //código de edição aqui
        }

       
    }
}
