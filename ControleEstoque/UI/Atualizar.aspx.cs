using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleEstoque.UI
{
    public partial class Atualizar : System.Web.UI.Page
    {
        BLL.Fornecedor forn = new BLL.Fornecedor();
        DAL.FornecedorDAL fornDAL = new DAL.FornecedorDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            //verifica se está carregando a página pela 1º vez
            if (!IsPostBack)
            {
                //verifica se está recebendo a variavel pelo ID
                if (Request.QueryString["id"] != null)
                {
                    //se a variavel id possui valor
                    if (Request.QueryString["id"].ToString() != "")
                    {
                        int idRecebido;
                        //tenta converter, se dar erro a saida é 0 (zero)
                        int.TryParse(Request.QueryString["id"], out idRecebido);

                        forn.ID = idRecebido;
                        forn = fornDAL.PreencherPeliID(forn);

                        if (forn.ID != 0)
                        {
                            btnAtulizar.Enabled = true;

                            lblID.Text = forn.ID.ToString();
                            txtNome.Text = forn.Nome;
                            txtCNPJ.Text = forn.CNPJ;
                            txtEndereco.Text = forn.Endereco;
                        }
                        else
                        {
                            lblID.Text = "ID INVÁLIDO";
                        }
                    }
                }
            }
        }

        protected void btnAtulizar_Click(object sender, EventArgs e)
        {
            forn.ID = Convert.ToInt32(lblID.Text);
            forn.Nome = txtNome.Text;
            forn.CNPJ = txtCNPJ.Text;
            forn.Endereco = txtEndereco.Text;

            fornDAL.Atualizar(forn);

            Response.Redirect("Listar.aspx");
        }
    }
}