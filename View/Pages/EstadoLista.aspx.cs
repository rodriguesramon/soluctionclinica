using System;
using System.Web;
using System.Web.UI;
using DAL.Persistence;

namespace View.Pages
{

    public partial class EstadoLista : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            getListaEstado();
        }

        public void getListaEstado(){
            try{
                EstadoDal estadoDal = new EstadoDal();
                gridListaEstado.DataSource = estadoDal.Listar();
                gridListaEstado.DataBind();

            }catch(Exception erro){
                lblMensagem.Text = erro.ToString();
            }
        }
    }
}
