using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleEstoque.UI
{
    public partial class Produto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.FornecedorDAL fornDAL = new DAL.FornecedorDAL();
                //Configurar a FONTE de dados da DropDownList
                ddlFornecedor.DataSource = fornDAL.Listar();
                //Configurar qual coluna será EXIBIDA na DropDownList
                ddlFornecedor.DataTextField = "NOME";
                //Configurar qual coluna fornecerá o VALOR da DropDownList
                ddlFornecedor.DataValueField = "ID";

                ddlFornecedor.DataBind();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            BLL.Produto pro = new BLL.Produto();
            DAL.ProdutoDAL proDAL = new DAL.ProdutoDAL();


            pro.Descricao = txtDescricao.Text;
            pro.Quantidade = int.Parse(txtQuantidade.Text);
            pro.ValorUnit = Decimal.Parse(txtValorUnit.Text);
            pro.IDFornecedor = Convert.ToInt32(ddlFornecedor.SelectedValue);

            proDAL.Cadastrar(pro);

            Response.Write("<script>Alert('Cadastro efetuado!')</script>");
            txtDescricao.Text = "";
            txtQuantidade.Text = "";
            txtValorUnit.Text = "";
            ddlFornecedor.SelectedIndex = 1;

            txtDescricao.Focus();//coloca o cursor do teclado
        }
    }
}