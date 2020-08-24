using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ControleEstoque.DAL
{
    public class UsuarioDAL
    {
        Conexao con = new Conexao();

        public BLL.Usuario Autenticar(BLL.Usuario us)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT USUARIO, SENHA, NOME_USUARIO, TIPO_USUARIO FROM TBUsuario WHERE USUARIO = @usuario AND SENHA = @senha";

            cmd.Parameters.AddWithValue("@usuario", us.User);
            cmd.Parameters.AddWithValue("@senha", us.Senha);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                us.User = dr["USUARIO"].ToString();
                us.NomeUser = dr["NOME_USUARIO"].ToString();
                us.Senha = dr["SENHA"].ToString();
                us.TipoUser = Convert.ToInt32(dr["TIPO_USUARIO"]);
                dr.Close();
            }
            else
            {
                us.User = "";
            }
            con.Desconectar();
            return us;
        }
    }
}