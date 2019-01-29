using System;
using BLL.Model;
using DAL.Persistence;
using System.Web;
using System.Web.UI;
namespace View.Pages
{
    public partial class EstadoCadastro : System.Web.UI.Page
    {
        protected void btnCadastrarEstado(object sender, EventArgs e)
        {
            try
            {
                Estado estado = new Estado();
                estado.Nome = nome.Text;
                estado.Sigla = sigla.Text;

                EstadoDal estadoDal = new EstadoDal();
                estadoDal.Salvar(estado);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro");
            }
        }
    }
}
