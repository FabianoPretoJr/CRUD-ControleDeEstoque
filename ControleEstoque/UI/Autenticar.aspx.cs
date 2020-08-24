using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleEstoque.UI
{
    public partial class Autenticar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAutenticar_Click(object sender, EventArgs e)
        {
            BLL.Usuario us = new BLL.Usuario();

            us.User = txtUsuario.Text;
            us.Senha = txtSenha.Text;

            DAL.UsuarioDAL usDAL = new DAL.UsuarioDAL();
           
            us = usDAL.Autenticar(us);

            if(us.User != "")
            {
                Response.Write("<script>alert('Ok')</script>");
                Session.Add("usuario", us.User);
                Session.Add("tipousuario", us.TipoUser);

                //Session.Add("BLLUsuario", us); Mandar todo objeto BLL de usuario

                Response.Redirect("Cadastro.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usúario ou senha invalidos')</script>");
            }
            txtUsuario.Text = "";
            txtUsuario.Focus();
        }
    }
}