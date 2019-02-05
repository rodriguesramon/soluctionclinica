<%@ Page Language="C#" AutoEventWireup="true" Inherits="View.Pages.PageTest" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>PageTest</title>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
</head>
<body>
        
	<form id="form1" runat="server">
        oi
        <button onclick="test()" type="button">Testss</button>
        
            <asp:Textbox runat="server" id="TestCampo"/>
            
        <asp:Button Text="Test"  runat="server" OnClientClick='GetName();return false;'  id="btn" />
       
        <div>
            <asp:ScriptManager ID="ScriptManager1" 
                EnablePageMethods="true" 
                EnablePartialRendering="true" runat="server" />
        </div>
    </form>
    
    <script>
            
        
        function test() {
            valor = document.getElementById("TestCampo").value;
            
          alert(valor);  
            return;
          var test = $.ajax({
                  type: "GET",
                  url: "PageTest.aspx/MetodoASerChamado",
                  success: function(msg) {
                    // Do something interesting here.
                      //alert(msg);
                  }
            });
            console.log(test);
        }
            
   
            function GetName() {  
                PageMethods.Name(Success, Failure);  
            }  
  
            function Success(result) {  
                alert(result);  
            }  
  
            function Failure(error) {  
                alert(error);  
            }  
    </script>
</body>
</html>
