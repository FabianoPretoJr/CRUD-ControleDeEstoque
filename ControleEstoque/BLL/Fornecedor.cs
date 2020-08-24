using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoque.BLL
{
    public class Fornecedor
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cnpj;
        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        private string _endereco;
        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
    }
}