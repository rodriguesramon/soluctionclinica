using System;
using BLL.Model;
using DAL.Persistence;
using System.Web;
using System.Web.UI;
using System.Drawing;

namespace View.Pages
{
    public partial class EstadoCadastro : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = "Iniciando o cadastro";
        }

        protected void btnCadastrarEstado(object sender, EventArgs e)
        {
            try
            {
                Estado estado = new Estado();
                estado.Nome = nome.Text;
                estado.Sigla = sigla.Text;

                EstadoDal estadoDal = new EstadoDal();
                estadoDal.Salvar(estado);

                nome.Text = "";
                sigla.Text = "";

                System.Threading.Thread.Sleep(5000);
                Response.Redirect("/Pages/EstadoCadastro.aspx");

            }
            catch (Exception erro)
            {
                lblMensagem.Text = erro.Message;
            }
        }
    }
}
