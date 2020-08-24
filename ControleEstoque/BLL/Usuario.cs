using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoque.BLL
{
    public class Usuario
    {
        private string _user;
        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        private string _nomeuser;
        public string NomeUser
        {
            get { return _nomeuser; }
            set { _nomeuser = value; }
        }

        private int _tipouser;
        public int TipoUser
        {
            get { return _tipouser; }
            set { _tipouser = value; }
        }
    }
}