<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site01.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detalhes</title>

    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery-1.9.1.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Detalhes do cliente</h3>
                    <br/><br/>
                    Informe o código da pessoa:<br/>
                    <asp:TextBox ID="txtCodigo" runat="server" placeholder="Codigo" Width="5%" CssClass="form-control" />
                    <br/>
                    <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick="btnPesquisaCliente"/>
                    
                    <a href="/Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                    <br/><br/>

                    <asp:Panel ID="pnlDados" runat="server">

                    Nome da pessoa:
                    <asp:TextBox ID="txtNome" runat="server"  Width="45%" CssClass="form-control" />
                    <br/><br/>
                    Endereço da pessoa:
                    <asp:TextBox ID="txtEndereco" runat="server"  Width="40%" CssClass="form-control" />
                    <br/><br/>
                    Email da pessoa:
                    <asp:TextBox ID="txtEmail" runat="server"  Width="25%" CssClass="form-control" />

                    <br/><br/>
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger btn-lg" OnClick="btnExcluirCliente"/>
                 
                    <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning btn-lg" OnClick="btnAtualizarCliente"/>
                    </asp:Panel>
                    <p>
                        <asp:Label id="lblMensagem" runat="server" />   
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
