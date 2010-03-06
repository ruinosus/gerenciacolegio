using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.Constantes;



public partial class ModuloPostagem_Consultar : System.Web.UI.Page
{
    #region Atributos
    private bool selecionado;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        // ClasseAuxiliar.ValidarUsuarioLogado(true);
        PostagemSelecionar1.OnSelect += new EventHandler(PostagemSelecionar1_OnSelect);
        HabilitarBotoes();
    }


    private void HabilitarBotoes()
    {
        DesabilitarBotoes();
        btnIncluir.Enabled = true;
        if (selecionado)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnImagem.Enabled = true;

            //switch (statusPostagem)
            //{
            //    case StatusPostagem.Ativa:
            //        {
            //            btnAlterar.Enabled = true;
            //            btnDesativar.Enabled = true;
            //            btnExcluir.Enabled = true;
            //            break;
            //        }
            //    case StatusPostagem.Excluida:
            //        {
            //            btnAtivar.Enabled = true;
            //            break;
            //        }
            //    case StatusPostagem.Inativa:
            //        {
            //            btnAtivar.Enabled = true;
            //            btnExcluir.Enabled = true;
            //            break;
            //        }
            //    case StatusPostagem.NaoAlterar:
            //        {
            //            btnAtivar.Enabled = true;
            //            btnExcluir.Enabled = true;
            //            break;
            //        }
            //}


        }

    }

    private void DesabilitarBotoes()
    {
        btnIncluir.Enabled = false;
        btnAlterar.Enabled = false;
        btnExcluir.Enabled = false;
        btnImagem.Enabled = false;
    }
    protected void PostagemSelecionar1_OnSelect(object sender, EventArgs e)
    {
        int idPostagem = PostagemSelecionar1.IdPostagem;

        if (idPostagem != 0)
        {
            selecionado = true;

        }
        HabilitarBotoes();
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        try
        {
            IPostagemProcesso processo = PostagemProcesso.Instance;
            Postagem postagem = new Postagem();
            postagem.ID = PostagemSelecionar1.IdPostagem;


            Session.Add("PostagemAlterar", processo.Consultar(postagem, Negocios.ModuloBasico.Enums.TipoPesquisa.E)[0]);
            Response.Redirect("Alterar.aspx", false);
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            IPostagemProcesso processo = PostagemProcesso.Instance;
            Postagem postagem = new Postagem();
            postagem.ID = PostagemSelecionar1.IdPostagem;

            processo.Excluir(postagem);
            processo.Confirmar();
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.POSTAGEM_EXCLUIDA;
            cvaAvisoDeInformacao.IsValid = false;
            PostagemSelecionar1.Consultar();
            selecionado = false;
            HabilitarBotoes();
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }

    protected void btnImagem_Click(object sender, EventArgs e)
    {
        try
        {
            IPostagemProcesso processo = PostagemProcesso.Instance;
            Postagem postagem = new Postagem();
            postagem.ID = PostagemSelecionar1.IdPostagem;


            Session.Add("PostagemIncluirImagem", processo.Consultar(postagem, Negocios.ModuloBasico.Enums.TipoPesquisa.E)[0]);
            Response.Redirect("Alterar.aspx", false);
        }
        catch (Exception ex)
        {

            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }
    }
}
