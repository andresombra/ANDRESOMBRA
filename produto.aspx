<%@ Page Language="C#" AutoEventWireup="true" CodeFile="produto.aspx.cs" Inherits="produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h3>PRODUTOS</h3>
    
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txt_codigo" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Listar Todos" OnClick="Button2_Click" />
        <asp:GridView ID="gvw_produtos" runat="server" EmptyDataText="Nenhum registro encontrado."></asp:GridView>
    </div>
    </form>
</body>
</html>
