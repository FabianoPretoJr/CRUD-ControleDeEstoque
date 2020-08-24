<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Atualizar.aspx.cs" Inherits="ControleEstoque.UI.Atualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID:<asp:Label ID="lblID" runat="server" Text=""></asp:Label><br/>
            Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br/>
            CNPJ:<asp:TextBox ID="txtCNPJ" runat="server"></asp:TextBox><br/>
            Endereço:<asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox><br/>

            <asp:Button ID="btnAtulizar" runat="server" Text="Atualizar" OnClick="btnAtulizar_Click" Enabled="false"/>
        </div>
    </form>
</body>
</html>
