using System;
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
        if (!IsPostBack)
        {
            LimparCampos();
        }
    }

  


    #region Métodos Privados
   


    protected void Confirmar(object sender, EventArgs e)
    {
        try
        {
            IImagemProcesso processo = ImagemProcesso.Instance;
            
            Imagem imagem = new Imagem();
            imagem.Titulo = txtTitulo.Text;
            imagem.SubTitulo = txtSubTitulo.Text;

            imagem.Corpo = txtCorpo.Text;

            
            if (fupImg.HasFile)
            {
                HttpPostedFile myFile = fupImg.PostedFile;

                System.Drawing.Image fullSizeImg = System.Drawing.Image.FromStream(myFile.InputStream);

                System.Drawing.Image.GetThumbnailImageAbort dummyCallBack = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);

                System.Drawing.Image thumbNailImg = fullSizeImg.GetThumbnailImage(200, 200, dummyCallBack, IntPtr.Zero);

                imagem.ImagemI = ClasseAuxiliar.ImageToByteArray(thumbNailImg);
            }

            processo.Incluir(imagem);
            processo.Confirmar();
            cvaAvisoDeInformacao.ErrorMessage = SiteConstantes.IMAGEM_INCLUIDA;
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

    }
    #endregion
}
