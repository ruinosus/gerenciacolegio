﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSite.Constantes;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.Processos;

public partial class ModuloPostagem_Incluir : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClasseAuxiliar.ValidarUsuarioLogado();
        if (!IsPostBack)
        {
            ClasseAuxiliar.CarregarComboEnum<TipoPostagem>(ddlTipoPostagem);
            CarregarComboLocal(null, null);
            LimparCampos();
        }
    }

    protected void CarregarComboLocal(object sender, EventArgs e)
    {

        TipoPostagem tipo = (TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue);
        lblLocalPostagem.Visible = true;
        ddlLocalPostagem.Visible = true;
        ClasseAuxiliar.CarregarComboEnum<LocalPostagem>(ddlLocalPostagem);
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


    }


    #region Métodos Privados
   


    protected void Confirmar(object sender, EventArgs e)
    {
        try
        {
            IPostagemProcesso processo = PostagemProcesso.Instance;

            if (((TipoPostagem)int.Parse(ddlTipoPostagem.SelectedValue)) == TipoPostagem.NaoAlterar)
                throw new Exception("Informe o tipo da postagem.");
            if (((LocalPostagem)int.Parse(ddlLocalPostagem.SelectedValue)) == LocalPostagem.NaoAlterar)
                throw new Exception("Informe o local da postagem.");

            Postagem postagem = new Postagem();
            postagem.Titulo = txtTitulo.Text;
            postagem.SubTitulo = txtSubTitulo.Text;

            postagem.Corpo = txtCorpo.Text;

            
            postagem.Local = int.Parse(ddlLocalPostagem.SelectedValue);
            postagem.Tipo = int.Parse(ddlTipoPostagem.SelectedValue);
            if (fupImgPostagem.HasFile)
            {
                HttpPostedFile myFile = fupImgPostagem.PostedFile;

                System.Drawing.Image fullSizeImg = System.Drawing.Image.FromStream(myFile.InputStream);

                System.Drawing.Image.GetThumbnailImageAbort dummyCallBack = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);

                System.Drawing.Image thumbNailImg = fullSizeImg.GetThumbnailImage(200, 200, dummyCallBack, IntPtr.Zero);

                postagem.ImagemI = ClasseAuxiliar.ImageToByteArray(thumbNailImg);
            }

            processo.Incluir(postagem);
            processo.Confirmar();
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.POSTAGEM_INCLUIDA;
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
 
        txtCorpo.Text= string.Empty;
        txtTitulo.Text = string.Empty;
        txtSubTitulo.Text = string.Empty;
        ddlLocalPostagem.SelectedIndex = 0;
        ddlTipoPostagem.SelectedIndex = 0;
    }
    #endregion
}
