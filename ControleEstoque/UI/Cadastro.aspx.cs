using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleEstoque.UI
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Usuario"] != null)
            {
                if(Session["Usuario"].ToString() != string.Empty)
                {
                    if(Convert.ToInt32(Session["tipousuario"]) == 0)
                    {
                        //usuario comum
                    }
                    else if(Convert.ToInt32(Session["tipousuario"]) == 0)
                    {
                        //Usuario adm
                    }
                }
                else
                {
                    Response.Redirect("Autenticar.aspx");
                }
            }
            else
            {
                Response.Redirect("Autenticar.aspx");
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.Fornecedor forn = new BLL.Fornecedor();

            forn.Nome = txtNome.Text;
            forn.Endereco = txtEndereco.Text;
            forn.CNPJ = txtCNPJ.Text;

            DAL.FornecedorDAL fornDAL = new DAL.FornecedorDAL();
            fornDAL.Cadastrar(forn);

            txtCNPJ.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";

            txtNome.Focus();//coloca o cursor do teclado

            Response.Write("<script>Alert('Cadastro efetuado!')</script>");
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Listar.aspx");
        }
    }
}