<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autenticar.aspx.cs" Inherits="ControleEstoque.UI.Autenticar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                USUARIO:&nbsp<asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox><br/>
                SENHA:&nbsp<asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox><br/>
                &nbsp&nbsp&nbsp&nbsp&nbsp<asp:Button ID="btnAutenticar" runat="server" Text="Autenticar" OnClick="btnAutenticar_Click" />
            </center>
        </div>
    </form>
</body>
</html>
