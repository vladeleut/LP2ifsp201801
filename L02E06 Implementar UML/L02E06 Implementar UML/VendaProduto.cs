using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02E06_Implementar_UML
{
    class VendaProduto
    {
        private int codigo, codVenda, codProduto;

        public void Cadastrar (VendaProduto item)
        {
            //código para cadastrar venda aqui
        }
        public VendaProduto Consultar(VendaProduto item)
        {
            //código para consultar aqui
            return item;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int CodVenda
        {
            get { return codVenda; }
            set { codVenda = value; }
        }
        public int CodProduto
        {
            get { return codProduto; }
            set { codProduto = value; }
        }
    }
}
