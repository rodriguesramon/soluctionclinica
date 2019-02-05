<%@ Page Language="C#" Inherits="View.Pages.EstadoAlterar" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>EstadoAlterar</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:Label id="lblMensagem" runat="server"/>
            <asp:TextBox id="idEstado" runat="server" />
            <asp:Button runat="server" id="btnPesquisar" Text="Consultar" OnClick="btnPesquisarEstado"/>
        <asp:Panel id="panelDetalhe" runat="server">
            <asp:TextBox id="nome" runat="server" />
        </asp:Panel>
	</form>
</body>
</html>
