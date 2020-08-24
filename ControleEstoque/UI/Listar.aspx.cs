using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleEstoque.UI
{
    public partial class Listar : System.Web.UI.Page
    {
        BLL.Fornecedor forn = new BLL.Fornecedor();
        DAL.FornecedorDAL fornDAL = new DAL.FornecedorDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //DataSource é a origem/fonte de dados 
                gvResultado.DataSource = fornDAL.Listar();

                //"Aplica" os dados na página do lado do cliente
                gvResultado.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            forn.Nome = txtFiltro.Text;
            gvResultado.DataSource = fornDAL.Listar(forn);
            gvResultado.DataBind();
        }

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            forn.ID = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "cmdExcluir")
            {
                fornDAL.Excluir(forn);
                Response.Write("<script>alert('Registro Excluido!')</script>");

                //click via codigo no botão filtrar para atualizar a página
                btnFiltrar_Click(null, null);
            }
            else if (e.CommandName == "cmdAtualizar")
            {
                Response.Redirect("Atualizar.aspx?id=" + forn.ID);
            }
        }
    }
}