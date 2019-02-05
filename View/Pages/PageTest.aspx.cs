using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
namespace View.Pages
{

    public partial class PageTest : System.Web.UI.Page
    {
        [WebMethod]
        public static string MetodoASerChamado()
        {
            return DateTime.Now.ToString();
        }

        public static string MeuMetodo(string nome)
        {
            return "Oi, " + nome;
        }

        [WebMethod]
        public static string Name()
        {
            string Name = "Hello Rohatash Kumar";
            return Name;
        }
        public static string Message()
        {
            return " MENSAGEM ";
        }
    }
}
