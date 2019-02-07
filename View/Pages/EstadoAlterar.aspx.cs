using System;
using System.Web;
using System.Web.UI;
using DAL.Persistence;
using BLL.Model;
namespace View.Pages
{

    public partial class EstadoAlterar : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e){
            panelDetalhe.Visible = false;
        }
        public void btnPesquisarEstado(object sender, EventArgs e)
        {
            /*
            try{
                int id_estado = Int32.Parse(idEstado.Text);
                EstadoDal estadoDal = new EstadoDal();
                Estado estado = estadoDal.PesquisarPorId(id_estado);

                if(estado != null){
                    panelDetalhe.Visible = true;
                    nome.Text = estado.Nome;
                }else{
                    panelDetalhe.Visible = false;
                    lblMensagem.Text = "Estado Invalido";
                }

            }catch(Exception erro){
                lblMensagem.Text = erro.ToString();
            }
            */
        }
    }
}
