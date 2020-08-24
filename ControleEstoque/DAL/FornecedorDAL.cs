using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ControleEstoque.DAL
{
    public class FornecedorDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Fornecedor forn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"INSERT INTO TBFornecedor(NOME, CNPJ, ENDERECO) VALUES (@nome, @cnpj, @endereco)";
            cmd.Parameters.AddWithValue("@nome", forn.Nome);
            cmd.Parameters.AddWithValue("@cnpj", forn.CNPJ);
            cmd.Parameters.AddWithValue("@endereco", forn.Endereco);
            cmd.ExecuteNonQuery(); //EXECUTAR COMANDO
            con.Desconectar();
        }

        public DataTable Listar()
        {
            DataTable dt = new DataTable();//Tabela de dados padrão C#(int, strin, double...)

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT ID, NOME, CNPJ, ENDERECO FROM TBFornecedor";

            //Adaptador de dados SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);//Preenche fazendo a adaptação
            con.Desconectar();
            return dt;
        }

        //SOBRE CARGA DE MÉTODO (METODOS COM O MESMO NOME, PORÉM COM ASSINATURAS DIFERENTES)
        public DataTable Listar(BLL.Fornecedor forn) //ESSA LINHA É A ASSINATURA
        {
            DataTable dt = new DataTable();//Tabela de dados padrão C#(int, strin, double...)

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT ID, NOME, CNPJ, ENDERECO FROM TBFornecedor WHERE NOME LIKE @nome";

            cmd.Parameters.AddWithValue("@nome", "%" + forn.Nome + "%");

            //Adaptador de dados SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);//Preenche fazendo a adaptação
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Fornecedor forn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE FROM TBFornecedor WHERE ID = @id";

            cmd.Parameters.AddWithValue("@id", forn.ID);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Fornecedor PreencherPeliID(BLL.Fornecedor forn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT ID, NOME, CNPJ, ENDERECO FROM TBFornecedor WHERE  ID=@id";
            cmd.Parameters.AddWithValue("@id", forn.ID);

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows)
            {
                dr.Read();
                forn.ID = Convert.ToInt32(dr["ID"]);
                forn.Nome = dr["NOME"].ToString();
                forn.CNPJ = dr["CNPJ"].ToString();
                forn.Endereco = dr["ENDERECO"].ToString();
                dr.Close();
            }
            else
            {
                forn.ID = 0;
            }

            con.Desconectar();
            return forn;
        }

        public void Atualizar(BLL.Fornecedor forn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE TBFornecedor SET NOME = @nome, CNPJ = @cnpj, ENDERECO = @endereco WHERE ID = @id";

            cmd.Parameters.AddWithValue("@id", forn.ID);
            cmd.Parameters.AddWithValue("@nome", forn.Nome);
            cmd.Parameters.AddWithValue("@cnpj", forn.CNPJ);
            cmd.Parameters.AddWithValue("@endereco", forn.Endereco);

            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}