using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using BLL.Model;
using System.Web.UI.WebControls;
using DAL.Persistence;

namespace View.Pages
{
    public partial class MedicoCadastro : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            bindEspecialidade();
        }

        public void btnCadastrarMedico(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico();
                medico.Nome = nome.Text;
                medico.Crm = crm.Text;
                medico.IdEspecialidade = Int32.Parse(IdEspecialidade.SelectedValue);

                MedicoDal medicoDal = new MedicoDal();
                medicoDal.Salvar(medico);

                nome.Text = "";
                crm.Text = "";

                string msg = "Medico  " + medico.Nome +
                              "  cadastrada com sucesso";
                lblMensagem.Text = msg;
                lblMensagem.Attributes.CssStyle.Add("color", "green");

                // Response.Redirect("/Pages/MedicoCadastro.aspx");
                //lblMensagem.Attributes.CssStyle.Add("color", "red");

            }
            catch (Exception erro)
            {
                lblMensagem.Attributes.CssStyle.Add("color", "red");
                lblMensagem.Text = erro.ToString();
            }
        }

        public void bindEspecialidade()
        {
            EspecialidadeDal especialidadeDal = new EspecialidadeDal();
            List<Especialidade> listaespecialidade = new List<Especialidade>();

            listaespecialidade = especialidadeDal.Listar();

            foreach (var especialidade in listaespecialidade)
            {
                IdEspecialidade.Items.Insert(0, new ListItem(especialidade.Descricao, especialidade.Id.ToString()));
            }

        }

    }

}
