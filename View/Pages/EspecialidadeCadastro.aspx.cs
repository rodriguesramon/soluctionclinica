using System;
using BLL.Model;
using DAL.Persistence;
using System.Web;
using System.Web.UI;

namespace View.Pages
{

    public partial class EspecialidadeCadastro : System.Web.UI.Page
    {

        protected void btnCadastrarEspecialidade(object sender, EventArgs e)
        {
            try
            {
                Especialidade especialidade = new Especialidade();
                especialidade.Descricao = descricao.Text;


                EspecialidadeDal especialidadeDal = new EspecialidadeDal();
                especialidadeDal.Salvar(especialidade);

                descricao.Text = "";


                string msg = "Especialidade " + especialidade.Descricao + 
                              " foi cadastrado com sucesso";
                lblMensagem.Text = msg;
                lblMensagem.Attributes.CssStyle.Add("color", "green");
               


                // Response.Redirect("/Pages/EspecialidadeCadastro.aspx");
                //lblMensagem.Attributes.CssStyle.Add("color", "red");


            }
            catch (Exception erro)
            {
                lblMensagem.Text = erro.ToString();
            }

        }
    
    }
}
