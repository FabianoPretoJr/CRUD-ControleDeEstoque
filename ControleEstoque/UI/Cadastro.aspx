<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="ControleEstoque.UI.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b><asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label></b><br/><br/>
            ID: (Automático)<br/>
            Nome do Fornecedor:
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br/>
            CNPJ:
            <asp:TextBox ID="txtCNPJ" runat="server"></asp:TextBox><br/>
            Endereço:
            <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox><br/>
            <asp:Button ID="btnCadastrar" runat="server" Text="cadastrar" OnClick="btnCadastrar_Click" />
            <asp:Button ID="btnListar" runat="server" Text="Listar" OnClick="btnListar_Click"/>
        </div>
    </form>
</body>
</html>
