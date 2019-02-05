using System;
using System.Web;
using System.Web.UI;

namespace View.Pages
{

    public partial class PageTest : System.Web.UI.Page
    {
        //[WebMethod]
        public static string MetodoASerChamado()
        {
            return DateTime.Now.ToString();
        }

        public static string MeuMetodo(string nome)
        {
            return "Oi, " + nome;
        }


        public static string Message()
        {
            return " MENSAGEM ";
        }
    }
}
