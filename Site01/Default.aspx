<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />

</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>projeto CRUD - controle de cliente</h1>
            
            Selecione a operação desejada:
            <asp:DropDownList ID="ddlMenu" runat="server">
                <asp:ListItem Value="0" Text="Escolha uma opção - "/>
                <asp:ListItem Value="1" Text="Cadastrar cliente - "/>
                <asp:ListItem Value="2" Text="Consultar cliente - "/>
                <asp:ListItem Value="3" Text="Obter dados do cliente - "/>



            </asp:DropDownList>

            <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary btn-lg" onclick="btnAcessar"/>
            <p>
                <asp:Label ID="lblMensagem" runat="server" />


            </p>
        </div>
    </form>
</body>
</html>
