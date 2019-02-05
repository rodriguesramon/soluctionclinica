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
        <button onclick="test()" type="button">Test</button>
        <button onclick="test()" type="button" id="btn">Test</button>
            <button onclick="getMessage()" type="button" id="btnss">Testss</button>
        <div>
            <asp:ScriptManager ID="ScriptManager1" 
                EnablePageMethods="true" 
                EnablePartialRendering="true" runat="server" />
        </div>
    </form>
    
    <script>
            
        function getMessage() {
    PageMethods.Message(, OnGetMessageFailure);
}    
        function test() {
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
            
     $("#btn").click(function () {
        PageMethods.MeuMetodo("Cigano Morrison Mendez");
    });
    </script>
</body>
</html>
