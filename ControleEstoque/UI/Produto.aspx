<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produto.aspx.cs" Inherits="ControleEstoque.UI.Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID: (Automático)<br/>
            Descrição: <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox><br/>
            Quantidade: <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox><br/>
            Valor Unitário: <asp:TextBox ID="txtValorUnit" runat="server"></asp:TextBox><br/>
            Fornecedor(id): <asp:DropDownList ID="ddlFornecedor" runat="server"></asp:DropDownList><br/>
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
        </div>
    </form>
</body>
</html>
