using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ControleEstoque.DAL
{
    public class ProdutoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Produto pro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();

            cmd.CommandText = @"INSERT INTO TBProduto(DESCRICAO, QUANTIDADE, VALOR_UNIT, ID_FORNECEDOR) VALUES (@descricao, @quantidade, @valorunit, @idfornecedor)";
            cmd.Parameters.AddWithValue("@descricao", pro.Descricao);
            cmd.Parameters.AddWithValue("@quantidade", pro.Quantidade);
            cmd.Parameters.AddWithValue("@valorunit", pro.ValorUnit);
            cmd.Parameters.AddWithValue("@idfornecedor", pro.IDFornecedor);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}