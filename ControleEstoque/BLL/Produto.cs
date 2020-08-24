using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoque.BLL
{
    public class Produto
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        private int _quantidade;
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        private decimal _valorunit;
        public decimal ValorUnit
        {
            get { return _valorunit; }
            set { _valorunit = value; }
        }

        private int _idfornecedor;
        public int IDFornecedor
        {
            get { return _idfornecedor; }
            set { _idfornecedor = value; }
        }
    }
}