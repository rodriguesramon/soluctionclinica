<%@ Page Language="C#" Inherits="View.Pages.EstadoLista" %>
<!DOCTYPE html>
<html>
    <head runat="server">
        <title>Default</title>
        <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
        <style>
            .posicaoButton{
                margin-top: 20px;
            }
        </style>
        
    </head>
    <body>
        <div class="container">
          <!-- #include file ="../menu.inc" -->
          <div class="">
            <form id="principal" runat="server" class="form-horizontal">
               <asp:GridView id="gridListaEstado" runat="server" CssClass="table table-bordered table-hover"/>
               <div class="form-group">
                <h3> <asp:Label id="lblMensagem" runat="server"/> </h3>
               </div>
            </form>   
          </div>
        </div> 
        <script src="../Scripts/jquery-1.9.1.js"></script>
        <script src="../Scripts/bootstrap.js"></script>
    </body>
</html>
