<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site01.Pages.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro</title>

    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Cadastro de cliente</h3>
                    <br />
                    Nome do cliente :
                    <br />
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ControlToValidate="txtNome" ErroMessage="Por favor digite o nome." ForeColor="Red" />
                    <br />
                    <br />
                    Endereço do cliente:<br />
                    <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial" Width="50%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredEndereco" runat="server" ControlToValidate="txtEndereco" ErroMessage="Por favor digite o Endereço." ForeColor="Red" />
                    <br />
                    <br />
                    Email do cliente:<br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" Width="25%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ControlToValidate="txtEmail" ErroMessage="Por favor digite o Email." ForeColor="Red" />
                    <br />
                    <br />

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>


                    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" onClick="btnCadastrarCliente"/>
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                </div>
                <br/>
            </div>
        </div>
    </form>
</body>
</html>
