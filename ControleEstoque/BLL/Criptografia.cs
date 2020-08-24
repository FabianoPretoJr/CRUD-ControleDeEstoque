using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace ControleEstoque.BLL
{
    public class Criptografia
    {
        //Métodos Manuais
        private string Criptografar(string conteudo)
        {
            UnicodeEncoding Ue = new UnicodeEncoding();

            byte[] bytes = Ue.GetBytes(conteudo.ToCharArray());
            string result = "";

            foreach (byte b in bytes)
            {
                result += String.Format("{0:x2}", b);
            }
            return result;
        }

        private string Descriptografar(string conteudo)
        {
            UnicodeEncoding Ue = new UnicodeEncoding();

            byte[] bytes = Ue.GetBytes(conteudo.ToCharArray());
            string result = "";

            foreach (byte b in bytes)
            {
                result += String.Format("{0:x2}", b);
            }
            return result;
        }


        //Método Recomendado
        private string GetMD5(string strPlain)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(strPlain);
            MD5 md5 = new MD5CryptoServiceProvider();
            string strHex = "";


            HashValue = md5.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }
    }
}