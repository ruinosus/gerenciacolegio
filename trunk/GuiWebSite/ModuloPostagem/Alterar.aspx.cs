using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.Constantes;

public partial class ModuloPostagem_Alterar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        if (!IsPostBack)
        {
            ClasseAuxiliar.CarregarComboEnum<TipoPagina>(ddlTipoPagina);
            ClasseAuxiliar.CarregarComboEnum<TipoPostagem>(ddlTipoPostagem);
            ClasseAuxiliar.CarregarComboEnum<LocalPostagem>(ddlLocalPostagem);

            LimparCampos();
            AlterarCenario();
            CarregarDados();
        }
    }

    private void CarregarDados()
    {
        if (Session["PostagemAlterar"] != null)
        {
            Postagem postagem = (Postagem)Session["PostagemAlterar"];

            ddlTipoPagina.SelectedValue = ((int)postagem.Pagina).ToString();
            ddlTipoPostagem.SelectedValue = ((int)postagem.Tipo).ToString();
            ddlLocalPostagem.SelectedValue = ((int)postagem.Local).ToString();
            txtCorpo.Text= postagem.Corpo;
            
            txtSubTitulo.Text = postagem.SubTitulo;
            txtTitulo.Text = postagem.Titulo;
            //fupImgPostagem.
        }
    }

    protected void AlterarCenario()
    {
        ddlTipoPagina.Visible = true;
        ddlTipoPostagem.Visible = true;
        ddlLocalPostagem.Visible = true;
        ddlLocalPostagem.Enabled = false;
        ddlTipoPagina.Enabled = false;
        ddlTipoPostagem.Enabled = false;
    }

    protected void CarregarComboTipoPagina(object sender, EventArgs e)
    {
        TipoPagina tipoPagina = (TipoPagina)int.Parse(ddlTipoPagina.SelectedValue);
        lblTipoPostagem.Visible = true;
        ddlTipoPostagem.Visible = true;
        lblLocalPostagem.Visible = true;
        ddlLocalPostagem.Visible = true;
        switch (tipoPagina)
        {
            case TipoPagina.NaoAlterar:
                {
                    lblTipoPostagem.Visible = false;
                    ddlTipoPostagem.Visible = false;
                    lblLocalPostagem.Visible = false;
                    ddlLocalPostagem.Visible = false;
                    break;
                }
            default:
                {
                    ClasseAuxiliar.CarregarComboEnum<TipoPostagem>(ddlTipoPostagem);
                    CarregarComboLocal(null, null);
                    break;
                }
        }

    }

    protected void CarregarComboLocal(object sender, EventArgs e)
    {
        TipoPostagem tipo = (TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue);
        TipoPagina tipoPagina = (TipoPagina)int.Parse(ddlTipoPagina.SelectedValue);
        lblLocalPostagem.Visible = true;
        ddlLocalPostagem.Visible = true;
        switch (tipo)
        {
            case TipoPostagem.NaoAlterar:
                {
                    lblLocalPostagem.Visible = false;
                    ddlLocalPostagem.Visible = false;
                    break;
                }
            default:
                {
                    lblLocalPostagem.Visible = true;
                    ddlLocalPostagem.Visible = true;
                    break;
                }
        }

        switch (tipoPagina)
        {
            case TipoPagina.Colegio:
                {
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemDefault>(ddlLocalPostagem);
                    break;
                }
            case TipoPagina.FundamentalI:
                {
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemFundamental>(ddlLocalPostagem);
                    break;
                }
            case TipoPagina.FundamentalII:
                {
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemFundamental>(ddlLocalPostagem);
                    break;
                }
            case TipoPagina.EducacaoInfantil:
                {
                    ClasseAuxiliar.CarregarComboEnum<LocalPostagemInfantil>(ddlLocalPostagem);
                    break;
                }
        }
    }


    #region Métodos Privados



    protected void Confirmar(object sender, EventArgs e)
    {
        try
        {
            IPostagemProcesso processo = PostagemProcesso.Instance;

            if (((TipoPagina)int.Parse(ddlTipoPagina.SelectedValue)) == TipoPagina.NaoAlterar)
                throw new Exception("Informe o tipo da página.");
            if (((TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue)) == TipoPostagem.NaoAlterar)
                throw new Exception("Informe o tipo da postagem.");
            if (((LocalPostagem)int.Parse(ddlLocalPostagem.SelectedValue)) == LocalPostagem.NaoAlterar)
                throw new Exception("Informe o local da postagem.");

            Postagem postagem = new Postagem();
            postagem = (Postagem)Session["PostagemAlterar"];
            postagem.Titulo = txtTitulo.Text;
            postagem.SubTitulo = txtSubTitulo.Text;

            postagem.Corpo = txtCorpo.Text;


            postagem.Local = int.Parse(ddlLocalPostagem.SelectedValue);
            postagem.Tipo = int.Parse(ddlTipoPostagem.SelectedValue);
            postagem.Pagina = int.Parse(ddlTipoPagina.SelectedValue);
            if (fupImgPostagem.HasFile)
            {
                HttpPostedFile myFile = fupImgPostagem.PostedFile;

                System.Drawing.Image fullSizeImg = System.Drawing.Image.FromStream(myFile.InputStream);

                System.Drawing.Image.GetThumbnailImageAbort dummyCallBack = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);

                System.Drawing.Image thumbNailImg = fullSizeImg.GetThumbnailImage(200, 200, dummyCallBack, IntPtr.Zero);

                postagem.ImagemI = ClasseAuxiliar.ImageToByteArray(thumbNailImg);
            }

            processo.Alterar(postagem);
            processo.Confirmar();
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.POSTAGEM_ALTERADA;
            cvaAvisoDeInformacao.IsValid = false;
            //LimparCampos();
            //CarregarComboLocal(null, null);
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;

        }
    }

    public bool ThumbnailCallback()
    {
        return false;
    }

    protected void Cancelar(object sender, EventArgs e)
    {
        Response.Redirect("Consultar.aspx", false);
    }

    protected void LimparCampos(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void LimparCampos()
    {

        txtCorpo.Text = string.Empty;
        txtTitulo.Text = string.Empty;
        txtSubTitulo.Text = string.Empty;
        ddlLocalPostagem.SelectedIndex = 0;
        ddlTipoPostagem.SelectedIndex = 0;
    }
    #endregion
}
