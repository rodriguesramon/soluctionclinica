﻿<%@ Page Language="C#" Inherits="View.Pages.CidadeCadastro" %>
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
          <div class="jumbotron">
            <form id="principal" runat="server" class="form-horizontal">
                <div class="form-group">
                   <div class="col-sm-3">
                       Nome Cidade         
                       <asp:Textbox id="descricao" autocomplete="off" runat="server" CssClass="form-control" />         
                   </div>
                   <div class="col-sm-3">
                       Estado
                       <asp:DropDownList id="idEstado" runat="server" CssClass="form-control">
                            <asp:ListItem  Value="1" Text="Amazonas"/>
                            <asp:ListItem  Value="2" Text="Sao Paulo"/>
                       </asp:DropDownList>
                   </div>
                        
                  <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-primary posicaoButton" OnClick="btnCadastrarCidade"/>  
                
               </div>
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
