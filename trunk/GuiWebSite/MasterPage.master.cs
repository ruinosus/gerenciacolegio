using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloSite.Excecoes;
using Negocios.ModuloSite.Constantes;
using Negocios.ModuloBasico.Constantes;

public partial class MasterPage : System.Web.UI.MasterPage
{
    #region Métodos Privados

    private void CarregarLogin()
    {
        lkbAdmin.Visible = false;
        if (Session["UsuarioLogado"] == null)
        {
            lblLogin.Text = "Login:";
            lblSenha.Text = "Senha:";

            txtLogin.Visible = true;
            txtSenha.Visible = true;
            btnLogar.Visible = true;
            lnkDeslogar.Visible = false;

      
        }
        else
        {
            Usuario usuario = (Usuario)Session["UsuarioLogado"];
            lblLogin.Text = "Bem vindo(a), " + usuario.Login;
            lblSenha.Text = string.Empty;
            lkbAdmin.Visible = true;

            txtLogin.Visible = false;
            txtSenha.Visible = false;
            btnLogar.Visible = false;
            lnkDeslogar.Visible = true;

            
        }
    }

    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarLogin();
    }

    protected void btnLogar_Click(object sender, EventArgs e)
    {
        IUsuarioProcesso processo = UsuarioProcesso.Instance;
        Usuario usuario = new Usuario();


        try
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                throw new UsuarioLoginOuSenhaInvalidosExcecao();
            }

            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;

            List<Usuario> usuarioList = processo.Consultar(usuario,Negocios.ModuloBasico.Enums.TipoPesquisa.E);

            if (usuarioList.Count > 0)
            {
                Session.Add("UsuarioLogado", usuarioList[0]);

                CarregarLogin();
            }
            else
                throw new UsuarioLoginOuSenhaInvalidosExcecao();
        }

        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }


    }

    protected void lnkDeslogar_Click(object sender, EventArgs e)
    {
        Session.Remove("UsuarioLogado");

        CarregarLogin();
        ClasseAuxiliar.ValidarUsuarioLogado();
        System.Web.HttpContext.Current.Response.Redirect(BasicoConstantes.PAGINA_PRINCIPAL, false);
    }
}
